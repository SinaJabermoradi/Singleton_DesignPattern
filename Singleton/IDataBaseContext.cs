using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
   public interface IDataBaseContext<T> where T : IData
    {
        public static DataBaseContext<T> GetContext { get; }

    }
}
