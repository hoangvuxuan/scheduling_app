using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calender
{
    public class PLAN_ITEM
    {
        private string _name;
        private Point _form_time;
        private Point _to_time;
        private string _status;
        private DateTime _date;

        public static List<string> Job_Status = new List<string>()
        {
            "DONE", "DOING", "COMING", "MISSED"
        };


        public string Name { get => _name; set => _name = value; }
        public Point Form_time { get => _form_time; set => _form_time = value; }
        public Point To_time { get => _to_time; set => _to_time = value; }
        public string Status { get => _status; set => _status = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }


}
