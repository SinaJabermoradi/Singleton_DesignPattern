using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class DataBaseContext<T> : IDataBaseContext<T>
    {
        private static DataBaseContext<T> _context;


        public static DataBaseContext<T> GetContext
        {
            get
            {
                _context = new DataBaseContext<T>();

                return _context;
            }
        }




    }
}
