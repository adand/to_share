using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartKoinoxristaProject
{
    class Cost
    {
        private int costValue;

        public Cost()
        {
            costValue = 3;
        }

        public Cost(int param)
        {
            costValue = param;
        }

        public int CostValue {
            get { return costValue; }
            set { costValue = value; } 
        }
    }
}
