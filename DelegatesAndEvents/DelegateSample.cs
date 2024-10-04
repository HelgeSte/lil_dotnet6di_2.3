using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public static class DelegateSample
    {
        public delegate void Del(string name);

        public static void PassMeWork(Del work) // Work is a passed delegate
        {
            work("delegate");
        }

    }


}
