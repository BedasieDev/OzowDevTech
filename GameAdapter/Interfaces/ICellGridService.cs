using GameAdapter.Requests;
using GameAdapter.Responses;
using GameLib.Models;

namespace GameAdapter.Interfaces
{
    public interface ICellGridService
    {
        CellGrid CellGrid { get; set; }
        GenericResponse InitGame(InitGameRequest request);
        GenericResponse Evaluate();
    }
}
