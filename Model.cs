using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Model
    {
        private int sec;

        public string AddSec()
        {
            return sec++.ToString();
        }
        public void Reset()
        {
            sec = 0;
        }
    }
}
