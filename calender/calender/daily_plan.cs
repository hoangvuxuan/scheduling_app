using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calender
{
    public partial class daily_plan : Form
    {

        private DateTime date;
        private PLAN_DATA job;
        public DateTime Date { get => date; set => date = value; }
        public PLAN_DATA Job { get => job; set => job = value; }

        public FlowLayoutPanel F_Panel = new FlowLayoutPanel();
        public daily_plan(DateTime date, PLAN_DATA job)
        {
            InitializeComponent();
            this.Date = date;
            this.Job = job;

            
            F_Panel.Width = Panel_Note.Width;
            F_Panel.Height = Panel_Note.Height;

            Panel_Note.Controls.Add(F_Panel);

            

            Date_Time_Picker_DP.Value = date;
        }
        void Show_Job_By_Date(DateTime date)
        {
            F_Panel.Controls.Clear();
            if (job != null && job.Job_list != null)
            {
                List<PLAN_ITEM> today_job = get_job_one_day(date);
                for (int i = 0; i < today_job.Count; i++)
                {
                    add_job(today_job[i]);
                }
            }
        }

        private void A_job_Edited(object sender, EventArgs e)
        {
             
        }

        private void A_job_Deleted(object sender, EventArgs e)
        {
            USER_CONTROL_A_Note uc = sender as USER_CONTROL_A_Note;
            PLAN_ITEM job = uc.Job;
            F_Panel.Controls.Remove(uc);
            Job.Job_list.Remove(job);
        }

        List<PLAN_ITEM> get_job_one_day(DateTime date)
        {
            var result = from j in job.Job_list
                                  where j.Date.Year == date.Year && j.Date.Month == date.Month && j.Date.Day == date.Day
                                  select j;
            return result.ToList();
        }
        private void Date_Time_Picker_DP_ValueChanged(object sender, EventArgs e)
        {
            Show_Job_By_Date((sender as DateTimePicker).Value);
        }

        private void BT_Last_Click(object sender, EventArgs e)
        {
            Date_Time_Picker_DP.Value = Date_Time_Picker_DP.Value.AddDays(-1);
        }

        private void BT_Next_Click(object sender, EventArgs e)
        {
            Date_Time_Picker_DP.Value = Date_Time_Picker_DP.Value.AddDays(1);

        }

        void add_job(PLAN_ITEM job)
        {
            USER_CONTROL_A_Note a_job = new USER_CONTROL_A_Note(job);
            a_job.Edited += A_job_Edited;
            a_job.Deleted += A_job_Deleted;
            F_Panel.Controls.Add(a_job);
        }

        private void MS_Item_Add_Note_Click(object sender, EventArgs e)
        {
            PLAN_ITEM iTEM= new PLAN_ITEM() { Date = Date_Time_Picker_DP.Value};

            Job.Job_list.Add(iTEM);
            add_job(iTEM);
        }

        private void MS_Item_Today_Click(object sender, EventArgs e)
        {
            Date_Time_Picker_DP.Value = DateTime.Now;
        }
    }
}
