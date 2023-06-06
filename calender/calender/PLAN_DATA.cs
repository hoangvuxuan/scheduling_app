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
        private List<PLAN_ITEM> _job_list;

        public List<PLAN_ITEM> Job_list { get { return _job_list; } set { _job_list = value; } }
    }
}
