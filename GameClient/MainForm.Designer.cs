namespace OzowDevAssessment
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonSeedGrid = new System.Windows.Forms.Button();
            this.TextBoxMainOutput = new System.Windows.Forms.TextBox();
            this.MainWorker = new System.ComponentModel.BackgroundWorker();
            this.NumericWidth = new System.Windows.Forms.NumericUpDown();
            this.NumericHeight = new System.Windows.Forms.NumericUpDown();
            this.LabelWidth = new System.Windows.Forms.Label();
            this.LabelHeight = new System.Windows.Forms.Label();
            this.LabelSpeed = new System.Windows.Forms.Label();
            this.NumericSpeed = new System.Windows.Forms.NumericUpDown();
            this.PanelConfig = new System.Windows.Forms.Panel();
            this.GroupBoxEvaluate = new System.Windows.Forms.GroupBox();
            this.ButtonRadioOff = new System.Windows.Forms.RadioButton();
            this.ButtonRadioOn = new System.Windows.Forms.RadioButton();
            this.LabelGenCount = new System.Windows.Forms.Label();
            this.LabelCount = new System.Windows.Forms.Label();
            this.BindingSourceMainFormModel = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NumericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSpeed)).BeginInit();
            this.PanelConfig.SuspendLayout();
            this.GroupBoxEvaluate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceMainFormModel)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSeedGrid
            // 
            this.ButtonSeedGrid.Location = new System.Drawing.Point(315, 16);
            this.ButtonSeedGrid.Name = "ButtonSeedGrid";
            this.ButtonSeedGrid.Size = new System.Drawing.Size(81, 23);
            this.ButtonSeedGrid.TabIndex = 1;
            this.ButtonSeedGrid.Text = "Seed Grid";
            this.ButtonSeedGrid.UseVisualStyleBackColor = true;
            this.ButtonSeedGrid.Click += new System.EventHandler(this.ButtonSeedGrid_Click);
            // 
            // TextBoxMainOutput
            // 
            this.TextBoxMainOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMainOutput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceMainFormModel, "OutputText", true));
            this.TextBoxMainOutput.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMainOutput.Location = new System.Drawing.Point(12, 66);
            this.TextBoxMainOutput.Multiline = true;
            this.TextBoxMainOutput.Name = "TextBoxMainOutput";
            this.TextBoxMainOutput.ReadOnly = true;
            this.TextBoxMainOutput.Size = new System.Drawing.Size(771, 377);
            this.TextBoxMainOutput.TabIndex = 2;
            // 
            // MainWorker
            // 
            this.MainWorker.WorkerReportsProgress = true;
            this.MainWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MainWorker_DoWork);
            this.MainWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.MainWorker_ProgressChanged);
            this.MainWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.MainWorker_RunWorkerCompleted);
            // 
            // NumericWidth
            // 
            this.NumericWidth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BindingSourceMainFormModel, "GridWidth", true));
            this.NumericWidth.Location = new System.Drawing.Point(44, 17);
            this.NumericWidth.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumericWidth.Name = "NumericWidth";
            this.NumericWidth.Size = new System.Drawing.Size(51, 20);
            this.NumericWidth.TabIndex = 4;
            this.NumericWidth.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NumericHeight
            // 
            this.NumericHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BindingSourceMainFormModel, "GridHeight", true));
            this.NumericHeight.Location = new System.Drawing.Point(145, 17);
            this.NumericHeight.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumericHeight.Name = "NumericHeight";
            this.NumericHeight.Size = new System.Drawing.Size(51, 20);
            this.NumericHeight.TabIndex = 4;
            this.NumericHeight.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // LabelWidth
            // 
            this.LabelWidth.AutoSize = true;
            this.LabelWidth.Location = new System.Drawing.Point(3, 21);
            this.LabelWidth.Name = "LabelWidth";
            this.LabelWidth.Size = new System.Drawing.Size(35, 13);
            this.LabelWidth.TabIndex = 5;
            this.LabelWidth.Text = "Width";
            // 
            // LabelHeight
            // 
            this.LabelHeight.AutoSize = true;
            this.LabelHeight.Location = new System.Drawing.Point(101, 21);
            this.LabelHeight.Name = "LabelHeight";
            this.LabelHeight.Size = new System.Drawing.Size(38, 13);
            this.LabelHeight.TabIndex = 5;
            this.LabelHeight.Text = "Height";
            // 
            // LabelSpeed
            // 
            this.LabelSpeed.AutoSize = true;
            this.LabelSpeed.Location = new System.Drawing.Point(202, 21);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(38, 13);
            this.LabelSpeed.TabIndex = 5;
            this.LabelSpeed.Text = "Speed";
            // 
            // NumericSpeed
            // 
            this.NumericSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BindingSourceMainFormModel, "SpeedSelection", true));
            this.NumericSpeed.Location = new System.Drawing.Point(246, 17);
            this.NumericSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericSpeed.Name = "NumericSpeed";
            this.NumericSpeed.Size = new System.Drawing.Size(51, 20);
            this.NumericSpeed.TabIndex = 4;
            // 
            // PanelConfig
            // 
            this.PanelConfig.Controls.Add(this.LabelWidth);
            this.PanelConfig.Controls.Add(this.LabelSpeed);
            this.PanelConfig.Controls.Add(this.NumericWidth);
            this.PanelConfig.Controls.Add(this.LabelHeight);
            this.PanelConfig.Controls.Add(this.ButtonSeedGrid);
            this.PanelConfig.Controls.Add(this.NumericHeight);
            this.PanelConfig.Controls.Add(this.NumericSpeed);
            this.PanelConfig.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.BindingSourceMainFormModel, "CanModifyValues", true));
            this.PanelConfig.Location = new System.Drawing.Point(128, 12);
            this.PanelConfig.Name = "PanelConfig";
            this.PanelConfig.Size = new System.Drawing.Size(413, 48);
            this.PanelConfig.TabIndex = 6;
            // 
            // GroupBoxEvaluate
            // 
            this.GroupBoxEvaluate.Controls.Add(this.ButtonRadioOff);
            this.GroupBoxEvaluate.Controls.Add(this.ButtonRadioOn);
            this.GroupBoxEvaluate.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.BindingSourceMainFormModel, "GridHasBeenInitialized", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.GroupBoxEvaluate.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxEvaluate.Name = "GroupBoxEvaluate";
            this.GroupBoxEvaluate.Size = new System.Drawing.Size(110, 48);
            this.GroupBoxEvaluate.TabIndex = 7;
            this.GroupBoxEvaluate.TabStop = false;
            this.GroupBoxEvaluate.Text = "Evaluate";
            // 
            // ButtonRadioOff
            // 
            this.ButtonRadioOff.AutoSize = true;
            this.ButtonRadioOff.Checked = true;
            this.ButtonRadioOff.Location = new System.Drawing.Point(63, 19);
            this.ButtonRadioOff.Name = "ButtonRadioOff";
            this.ButtonRadioOff.Size = new System.Drawing.Size(39, 17);
            this.ButtonRadioOff.TabIndex = 0;
            this.ButtonRadioOff.TabStop = true;
            this.ButtonRadioOff.Text = "Off";
            this.ButtonRadioOff.UseVisualStyleBackColor = true;
            // 
            // ButtonRadioOn
            // 
            this.ButtonRadioOn.AutoSize = true;
            this.ButtonRadioOn.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.BindingSourceMainFormModel, "EvaluatationInProgress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ButtonRadioOn.Location = new System.Drawing.Point(6, 19);
            this.ButtonRadioOn.Name = "ButtonRadioOn";
            this.ButtonRadioOn.Size = new System.Drawing.Size(39, 17);
            this.ButtonRadioOn.TabIndex = 0;
            this.ButtonRadioOn.Text = "On";
            this.ButtonRadioOn.UseVisualStyleBackColor = true;
            this.ButtonRadioOn.CheckedChanged += new System.EventHandler(this.ButtonRadioOn_CheckedChanged);
            // 
            // LabelGenCount
            // 
            this.LabelGenCount.AutoSize = true;
            this.LabelGenCount.Location = new System.Drawing.Point(547, 33);
            this.LabelGenCount.Name = "LabelGenCount";
            this.LabelGenCount.Size = new System.Drawing.Size(93, 13);
            this.LabelGenCount.TabIndex = 8;
            this.LabelGenCount.Text = "Generation Count:";
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceMainFormModel, "GenerationCount", true));
            this.LabelCount.Location = new System.Drawing.Point(646, 33);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(13, 13);
            this.LabelCount.TabIndex = 8;
            this.LabelCount.Text = "0";
            // 
            // BindingSourceMainFormModel
            // 
            this.BindingSourceMainFormModel.DataSource = typeof(OzowDevAssessment.MainFormModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 455);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.LabelGenCount);
            this.Controls.Add(this.GroupBoxEvaluate);
            this.Controls.Add(this.PanelConfig);
            this.Controls.Add(this.TextBoxMainOutput);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ozow Assessment";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSpeed)).EndInit();
            this.PanelConfig.ResumeLayout(false);
            this.PanelConfig.PerformLayout();
            this.GroupBoxEvaluate.ResumeLayout(false);
            this.GroupBoxEvaluate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceMainFormModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonSeedGrid;
        private System.Windows.Forms.TextBox TextBoxMainOutput;
        private System.ComponentModel.BackgroundWorker MainWorker;
        private System.Windows.Forms.NumericUpDown NumericWidth;
        private System.Windows.Forms.NumericUpDown NumericHeight;
        private System.Windows.Forms.Label LabelWidth;
        private System.Windows.Forms.Label LabelHeight;
        private System.Windows.Forms.Label LabelSpeed;
        private System.Windows.Forms.NumericUpDown NumericSpeed;
        private System.Windows.Forms.BindingSource BindingSourceMainFormModel;
        private System.Windows.Forms.Panel PanelConfig;
        private System.Windows.Forms.GroupBox GroupBoxEvaluate;
        private System.Windows.Forms.RadioButton ButtonRadioOff;
        private System.Windows.Forms.RadioButton ButtonRadioOn;
        private System.Windows.Forms.Label LabelGenCount;
        private System.Windows.Forms.Label LabelCount;
    }
}

