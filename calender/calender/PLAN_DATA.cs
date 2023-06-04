using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calender
{
    [Serializable]
    public class PLAN_DATA
    {
        private List<PLAN_ITEM> _job;

        internal List<PLAN_ITEM> Job { get => _job; set => _job = value; }
    }
}
