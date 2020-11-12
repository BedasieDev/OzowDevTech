using System;

namespace GameLib.Models.CellGridCommands
{
    public abstract class CellGridCommandBase
    {
        protected T Execute<T>(Func<T> func)
        {
            return func();
        }
    }
}