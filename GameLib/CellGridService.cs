//using GameLib.Interfaces;
//using GameLib.Models;
//using GameLib.Requests;
//using GameLib.Responses;
//using System;

//namespace GameLib
//{
//    public class CellGridService : ICellGridService
//    {
//        public CellGrid CellGrid { get; set; }

//        public GenericResponse InitGame(InitGameRequest request)
//        {
//            try
//            {
//                CellGrid = new CellGrid(request.GridWidth, request.GridHeight);
//                return GetGenericSuccessfulResponse();
//            }
//            catch (Exception x)
//            {
//                return GetFailedGenericResponse(x);
//            }
//        }

//        public GenericResponse Evaluate()
//        {
//            try
//            {
//                CellGrid.EvaluateCells();
//                return GetGenericSuccessfulResponse();

//            }
//            catch (Exception x)
//            {
//                return GetFailedGenericResponse(x);
//            }
//        }

//        #region Private Functions
//        private GenericResponse GetGenericSuccessfulResponse()
//        {
//            return new GenericResponse()
//            {
//                Successful = true,
//                Output = CellGrid.GetGenerationOutput()
//            };
//        }

//        private GenericResponse GetFailedGenericResponse(Exception x)
//        {
//            return new GenericResponse()
//            {
//                Successful = false,
//                ErrorMessage = x.ToString()
//            };
//        } 
//        #endregion
//    }
//}
