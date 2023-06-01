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
    public partial class calender_form : Form
    {
        public calender_form()
        {
            InitializeComponent();
            load_Matrix();
        }

        void load_Matrix()
        {
            Button old_btn = new Button() { Width = 0, Height = 0, Location = new Point(0, 0)};
            for(int i = 0; i < CONS.day_of_column; i++)
            {
                for(int j = 0; j < CONS.day_of_week; j++)
                {
                    Button btn= new Button() { Width = CONS.date_btn_with, Height = CONS.date_btn_height};
                    btn.Location = new Point(old_btn.Location.X + old_btn.Width, old_btn.Location.Y);
                    Panel_Matrix.Controls.Add(btn);

                    old_btn = btn;
                }

                old_btn = new Button() { Width = 0, Height = 0, Location = new Point(0, old_btn.Location.Y + CONS.date_btn_height) };
            }
        }





















        private void BT_Today_Click(object sender, EventArgs e)
        {

        }

        private void BT_Monday_Click(object sender, EventArgs e)
        {

        }

        private void BT_Next_Click(object sender, EventArgs e)
        {

        }
    }
}
