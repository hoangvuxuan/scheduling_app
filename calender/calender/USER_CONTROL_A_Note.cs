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
    public partial class USER_CONTROL_A_Note : UserControl
    {
        private PLAN_ITEM _job;
        public PLAN_ITEM Job { get => _job; set => _job = value; }
        public USER_CONTROL_A_Note(PLAN_ITEM job)
        {
            InitializeComponent();
            CBB_Status.DataSource = PLAN_ITEM.Job_Status;
            this.Job = job;
            show_infor();
        }

        void show_infor ()
        {
            TB_Note.Text = Job.Name;
            NUD_Hours.Value = Job.Form_time.X;
            NMD_Minutes.Value= Job.Form_time.Y; 
            NUD_To_Hours.Value = Job.To_time.X;
            NUD_To_Minutes.Value = Job.To_time.Y;
            CBB_Status.SelectedIndex = PLAN_ITEM.Job_Status.IndexOf(Job.Status);
            CB_Done.Checked = Job.Status == "DONE";


        }

        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
         

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            //deleted = null;
            if(deleted != null)
            {
               deleted(this, new EventArgs());
            }
        }

        private void BT_Fix_Click(object sender, EventArgs e)
        {
            Job.Name = TB_Note.Text;
            Job.Form_time = new Point((int)NUD_Hours.Value, (int)NMD_Minutes.Value);
            Job.To_time = new Point((int)NUD_To_Hours.Value, (int)NUD_To_Minutes.Value);
            Job.Status = CBB_Status.SelectedItem.ToString();
            if (edited != null)
            {
                edited(this, new EventArgs());
            }
        }

        private void CB_Done_CheckedChanged(object sender, EventArgs e)
        {
            CBB_Status.SelectedIndex = CB_Done.Checked ? 0 : 1;
        }
    }
}
