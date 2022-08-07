using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Data : IData
    {
        public string Name { get ; set ; }
        public string Family { get ; set ; }
        public long Age { get ; set; }
        public long Id { get ; set ; }
    }
}
