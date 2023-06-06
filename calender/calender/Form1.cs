using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace calender
{
    public partial class calender_form : Form
    {
        private List<List<Button>> matrix;

        private string _file_path = "data.xml";

        private PLAN_DATA _job;
       
        public PLAN_DATA Job { get => _job; set => _job = value; }
         
        
        public calender_form()
        {

            #region properties
            
            #endregion
            InitializeComponent();
            load_Matrix();

            add_Number_To_Matrix_By_Day(Day_Time_Picker.Value);

            try
            {
                set_default();

                Deserialize_To_XML(_file_path);
                MessageBox.Show("1");
            }
            catch
            {
                set_default();
                MessageBox.Show("2");

            }

        }

        void set_default()
        {
            Job = new PLAN_DATA();
            Job.Job_list = new List<PLAN_ITEM>();
            Job.Job_list.Add(new PLAN_ITEM()
            {
                Name = "thu nghiem",
                Form_time = new Point(4, 0),
                To_time = new Point(5, 9),
                Status = PLAN_ITEM.Job_Status[0],
                Date = DateTime.Now
            });

            Job.Job_list.Add(new PLAN_ITEM()
            {
                Name = "thu nghiem",
                Form_time = new Point(4, 0),
                To_time = new Point(5, 9),
                Status = PLAN_ITEM.Job_Status[0],
                Date = DateTime.Now
            });

        }

        void load_Matrix()
        {
            matrix = new List<List<Button>>();
             
            Button old_btn = new Button() { Width = 0, Height = 0, Location = new Point(0, 0)};
            for(int i = 0; i < CONS.day_of_column; i++)
            {
                matrix.Add(new List<Button>());
                for(int j = 0; j < CONS.day_of_week; j++)
                {
                    Button btn= new Button() { Width = CONS.date_btn_with, Height = CONS.date_btn_height};
                    btn.Location = new Point(old_btn.Location.X + old_btn.Width, old_btn.Location.Y);
                    Panel_Matrix.Controls.Add(btn);
                    matrix[i].Add(btn);

                    old_btn = btn;
                }

                old_btn = new Button() { Width = 0, Height = 0, Location = new Point(0, old_btn.Location.Y + CONS.date_btn_height) };
            }
        }

        private List<string> day_Of_Week = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"  };

        

        int day_Of_Month(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if(date.Year % 4 == 0)
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                default:
                    return 30;

            }
        }
        void add_Number_To_Matrix_By_Day(DateTime date)
        {
            clear_Matrix_Value();
            DateTime use_date = new DateTime(date.Year, date.Month, 1);
            

            int line = 0;
            for(int i = 1; i <= day_Of_Month(date); i++)
            {
                int col = day_Of_Week.IndexOf(use_date.DayOfWeek.ToString());
                Button btn = matrix[line][col];
                btn.Text = i.ToString();
                btn.Font = new Font(btn.Font.FontFamily, 18);
               
                if(col >= 6)
                {
                    line++;
                } 

                if(use_date.Year == date.Year && use_date.Month == date.Month && date.Day == use_date.Day)
                {
                    btn.BackColor = Color.Blue; 
                    btn.ForeColor = Color.Yellow; 
                }

                if (use_date.Year == DateTime.Now.Year && use_date.Month == DateTime.Now.Month && DateTime.Now.Day == use_date.Day)
                {
                    btn.BackColor = Color.Green;
                    btn.ForeColor = Color.LightYellow;
                }
                use_date = use_date.AddDays(1);

                //MessageBox.Show(use_date.Date.ToString());
            }
            
            
        }

        void clear_Matrix_Value()
        {
            for(int i  = 0; i < matrix.Count; i++)
            {
                for(int j = 0; j < matrix[i].Count; j++)
                {
                    Button btn = matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }
        }

        private void Day_Time_Picker_ValueChanged(object sender, EventArgs e)
        {
            var date = sender as DateTimePicker;
            add_Number_To_Matrix_By_Day(date.Value);
        }

        private void BT_Next_Click(object sender, EventArgs e)
        {
            Day_Time_Picker.Value = Day_Time_Picker.Value.AddMonths(1);
        }

        private void BT_Last_Click(object sender, EventArgs e)
        {
            Day_Time_Picker.Value = Day_Time_Picker.Value.AddMonths(-1);

        }

        private void BT_Today_Click(object sender, EventArgs e)
        {
            Day_Time_Picker.Value = DateTime.Today;
        }

        private void Serialize_To_XML(object data, string file_path)
        {
            FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.Write); 
            XmlSerializer sr = new XmlSerializer(typeof(PLAN_DATA));
            sr.Serialize(fs, data);
            MessageBox.Show("3");

            fs.Close();

        }

        private object Deserialize_To_XML(string file_path)
        {
            FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.Read);
            XmlSerializer sr = new XmlSerializer(typeof(PLAN_DATA));
            object result = sr.Deserialize(fs);
            fs.Close();
            MessageBox.Show("4");

            return result;
        }

        private void calender_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialize_To_XML(Job, _file_path);
        }
    }
}
