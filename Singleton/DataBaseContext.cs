using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class DataBaseContext<T> : IDataBaseContext<T> where T : IData 
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
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($" This Is Your Data ==> " +
                              $"\n Name :  {data.Name}" +
                              $"\n Family : {data.Family} " +
                              $"\n Age : {data.Age} " +
                              $"\n Id : {data.Id} " +
                              $"\n------------------------------------------" +
                              $"\n Your Data Add To DataBase ");
        }
        public void Delete(T data)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($" This Is Your Data ==> " +
                              $"\n Name :  {data.Name}" +
                              $"\n Family : {data.Family} " +
                              $"\n Age : {data.Age} " +
                              $"\n Id : {data.Id} " +
                              $"\n------------------------------------------" +
                              $"\n Your Data Delete To DataBase ");
        }
        public void Update(long dataId, T data)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($" This Is Your Data ==> " +
                              $"\n Name :  {data.Name}" +
                              $"\n Family : {data.Family} " +
                              $"\n Age : {data.Age} " +
                              $"\n Id : {data.Id} " +
                              $"\n------------------------------------------" +
                              $"\n Your Data Update To DataBase ");
        }


        #endregion

        #endregion
    }
}
