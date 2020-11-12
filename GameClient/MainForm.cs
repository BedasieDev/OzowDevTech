using GameAdapter.Interfaces;
using GameAdapter.Requests;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace OzowDevAssessment
{
    public partial class MainForm : Form
    {
        ICellGridService service;
        MainFormModel model;
        UnityResolver UnityResolver;

        public MainForm()
        {
            InitializeComponent();

            UnityResolver = new UnityResolver();
            service = UnityResolver.Resolve<ICellGridService>();
            model = new MainFormModel();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetBindingSource(true);
        }

        private void ButtonSeedGrid_Click(object sender, EventArgs e)
        {
            var request = new InitGameRequest()
            {
                GridHeight = model.GridHeight,
                GridWidth = model.GridWidth
            };

            var response = service.InitGame(request);

            if (response.Successful)
            {
                model.GridHasBeenInitialized = true;
                model.OutputText = response.Output;
                model.GenerationCount = 0;
                SetBindingSource();
            }

            else
            {
                MessageBox.Show(response.ErrorMessage);
            }
        }

        private void MainWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(50);

            while (model.EvaluatationInProgress)
            {
                var response = service.Evaluate();

                if (response.Successful)
                {
                    model.OutputText = response.Output;
                    model.GenerationCount++;
                }
                else
                {
                    MessageBox.Show(response.ErrorMessage);
                    MainWorker.CancelAsync();
                }

                MainWorker.ReportProgress(0);
                Thread.Sleep(model.ThreadSleep);
            }
        }

        private void MainWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SetBindingSource();
        }

        private void MainWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            model.GridHasBeenInitialized = false;
            SetBindingSource();
        }

        private void SetBindingSource(bool setDataSource = false)
        {
            if (setDataSource)
                BindingSourceMainFormModel.DataSource = model;

            BindingSourceMainFormModel.ResetBindings(false);
        }

        private void ButtonRadioOn_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                MainWorker.RunWorkerAsync();
        }
    }
}
