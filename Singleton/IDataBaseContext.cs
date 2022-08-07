using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
   public interface IDataBaseContext<T>
    {
        public static DataBaseContext<T> GetContext { get; }

    }
}
