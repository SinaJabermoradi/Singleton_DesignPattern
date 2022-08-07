using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBaseContext<IData>.GetContext.Add(new Data
            {
                Name = "sina",
                Family = "Jabermoradi",
                Age = 21,
                Id = 1
            });

            DataBaseContext<IData>.GetContext.Delete(new Data
            {
                Name = "Samane",
                Family = "Sasani",
                Age = 25,
                Id = 2
            });
            
            DataBaseContext<IData>.GetContext.Update(5,new Data
            {
                Name = "sina",
                Family = "falaki",
                Age = 21,
                Id = 3
            });
        }
    }
}
