using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class DataBaseContext<T> : IDataBaseContext<T>
    {

        private static DataBaseContext<T> _context;


        #region Behaviors

        #region Constructors

        private DataBaseContext()
        {


        }

    #endregion

      
        #region Getter & Setter


    public static DataBaseContext<T> GetContext
    {
        get
        {
            _context = new DataBaseContext<T>();

            return _context;
        }
    }


        #endregion


        #region Opereations

        public void Add(T data)
        {
            Console.WriteLine("Add To DataBase ");
        }
        public void Delete(T data)
        {
            Console.WriteLine("Delete To DataBase ");
        }
        public void Update(long dataId,T data)
        {
            Console.WriteLine("Update To DataBase ");
        }
        

        #endregion

        #endregion
    }
}
