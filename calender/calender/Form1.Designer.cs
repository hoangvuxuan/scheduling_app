namespace calender
{
    partial class calender_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NUD_Notify = new System.Windows.Forms.NumericUpDown();
            this.CB_Notify = new System.Windows.Forms.CheckBox();
            this.BT_Today = new System.Windows.Forms.Button();
            this.Day_Time_Picker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel_Matrix = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BT_Last = new System.Windows.Forms.Button();
            this.BT_Next = new System.Windows.Forms.Button();
            this.BT_Sunday = new System.Windows.Forms.Button();
            this.BT_Saturday = new System.Windows.Forms.Button();
            this.BT_Friday = new System.Windows.Forms.Button();
            this.BT_Thursday = new System.Windows.Forms.Button();
            this.BT_Wenesday = new System.Windows.Forms.Button();
            this.BT_Tuesday = new System.Windows.Forms.Button();
            this.BT_Monday = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Notify)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 548);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NUD_Notify);
            this.panel3.Controls.Add(this.CB_Notify);
            this.panel3.Controls.Add(this.BT_Today);
            this.panel3.Controls.Add(this.Day_Time_Picker);
            this.panel3.Location = new System.Drawing.Point(9, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 47);
            this.panel3.TabIndex = 1;
            // 
            // NUD_Notify
            // 
            this.NUD_Notify.Location = new System.Drawing.Point(130, 5);
            this.NUD_Notify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.NUD_Notify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Notify.Name = "NUD_Notify";
            this.NUD_Notify.Size = new System.Drawing.Size(63, 22);
            this.NUD_Notify.TabIndex = 3;
            this.NUD_Notify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CB_Notify
            // 
            this.CB_Notify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CB_Notify.AutoSize = true;
            this.CB_Notify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Notify.Location = new System.Drawing.Point(52, 7);
            this.CB_Notify.Name = "CB_Notify";
            this.CB_Notify.Size = new System.Drawing.Size(74, 20);
            this.CB_Notify.TabIndex = 2;
            this.CB_Notify.Text = "NOTIFY";
            this.CB_Notify.UseVisualStyleBackColor = true;
            // 
            // BT_Today
            // 
            this.BT_Today.Location = new System.Drawing.Point(588, 0);
            this.BT_Today.Margin = new System.Windows.Forms.Padding(5);
            this.BT_Today.Name = "BT_Today";
            this.BT_Today.Size = new System.Drawing.Size(107, 23);
            this.BT_Today.TabIndex = 1;
            this.BT_Today.Text = "TODAY";
            this.BT_Today.UseVisualStyleBackColor = true;
            this.BT_Today.Click += new System.EventHandler(this.BT_Today_Click);
            // 
            // Day_Time_Picker
            // 
            this.Day_Time_Picker.Location = new System.Drawing.Point(272, 3);
            this.Day_Time_Picker.Name = "Day_Time_Picker";
            this.Day_Time_Picker.Size = new System.Drawing.Size(310, 22);
            this.Day_Time_Picker.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Panel_Matrix);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 489);
            this.panel2.TabIndex = 0;
            // 
            // Panel_Matrix
            // 
            this.Panel_Matrix.Location = new System.Drawing.Point(58, 79);
            this.Panel_Matrix.Name = "Panel_Matrix";
            this.Panel_Matrix.Size = new System.Drawing.Size(746, 407);
            this.Panel_Matrix.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BT_Last);
            this.panel4.Controls.Add(this.BT_Next);
            this.panel4.Controls.Add(this.BT_Sunday);
            this.panel4.Controls.Add(this.BT_Saturday);
            this.panel4.Controls.Add(this.BT_Friday);
            this.panel4.Controls.Add(this.BT_Thursday);
            this.panel4.Controls.Add(this.BT_Wenesday);
            this.panel4.Controls.Add(this.BT_Tuesday);
            this.panel4.Controls.Add(this.BT_Monday);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(857, 70);
            this.panel4.TabIndex = 0;
            // 
            // BT_Last
            // 
            this.BT_Last.Location = new System.Drawing.Point(3, 3);
            this.BT_Last.Name = "BT_Last";
            this.BT_Last.Size = new System.Drawing.Size(47, 62);
            this.BT_Last.TabIndex = 8;
            this.BT_Last.Text = "<<";
            this.BT_Last.UseVisualStyleBackColor = true;
            // 
            // BT_Next
            // 
            this.BT_Next.Location = new System.Drawing.Point(807, 0);
            this.BT_Next.Name = "BT_Next";
            this.BT_Next.Size = new System.Drawing.Size(47, 62);
            this.BT_Next.TabIndex = 7;
            this.BT_Next.Text = ">>";
            this.BT_Next.UseVisualStyleBackColor = true;
            this.BT_Next.Click += new System.EventHandler(this.BT_Next_Click);
            // 
            // BT_Sunday
            // 
            this.BT_Sunday.Location = new System.Drawing.Point(698, 3);
            this.BT_Sunday.Name = "BT_Sunday";
            this.BT_Sunday.Size = new System.Drawing.Size(103, 63);
            this.BT_Sunday.TabIndex = 1;
            this.BT_Sunday.Text = "SUNDAY";
            this.BT_Sunday.UseVisualStyleBackColor = true;
            // 
            // BT_Saturday
            // 
            this.BT_Saturday.Location = new System.Drawing.Point(589, 3);
            this.BT_Saturday.Name = "BT_Saturday";
            this.BT_Saturday.Size = new System.Drawing.Size(109, 63);
            this.BT_Saturday.TabIndex = 2;
            this.BT_Saturday.Text = "STATURDAY";
            this.BT_Saturday.UseVisualStyleBackColor = true;
            // 
            // BT_Friday
            // 
            this.BT_Friday.Location = new System.Drawing.Point(482, 3);
            this.BT_Friday.Name = "BT_Friday";
            this.BT_Friday.Size = new System.Drawing.Size(103, 63);
            this.BT_Friday.TabIndex = 3;
            this.BT_Friday.Text = "FRIDAY";
            this.BT_Friday.UseVisualStyleBackColor = true;
            // 
            // BT_Thursday
            // 
            this.BT_Thursday.Location = new System.Drawing.Point(376, 4);
            this.BT_Thursday.Name = "BT_Thursday";
            this.BT_Thursday.Size = new System.Drawing.Size(108, 63);
            this.BT_Thursday.TabIndex = 4;
            this.BT_Thursday.Text = "THURSDAY";
            this.BT_Thursday.UseVisualStyleBackColor = true;
            // 
            // BT_Wenesday
            // 
            this.BT_Wenesday.Location = new System.Drawing.Point(265, 3);
            this.BT_Wenesday.Name = "BT_Wenesday";
            this.BT_Wenesday.Size = new System.Drawing.Size(105, 63);
            this.BT_Wenesday.TabIndex = 5;
            this.BT_Wenesday.Text = "WENESDAY";
            this.BT_Wenesday.UseVisualStyleBackColor = true;
            // 
            // BT_Tuesday
            // 
            this.BT_Tuesday.Location = new System.Drawing.Point(164, 4);
            this.BT_Tuesday.Name = "BT_Tuesday";
            this.BT_Tuesday.Size = new System.Drawing.Size(95, 63);
            this.BT_Tuesday.TabIndex = 6;
            this.BT_Tuesday.Text = "TUESDAY";
            this.BT_Tuesday.UseVisualStyleBackColor = true;
            // 
            // BT_Monday
            // 
            this.BT_Monday.Location = new System.Drawing.Point(55, 4);
            this.BT_Monday.Name = "BT_Monday";
            this.BT_Monday.Size = new System.Drawing.Size(103, 63);
            this.BT_Monday.TabIndex = 0;
            this.BT_Monday.Text = "MONDAY";
            this.BT_Monday.UseVisualStyleBackColor = true;
            this.BT_Monday.Click += new System.EventHandler(this.BT_Monday_Click);
            // 
            // calender_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 611);
            this.Controls.Add(this.panel1);
            this.Name = "calender_form";
            this.Text = "calender";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Notify)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_Today;
        private System.Windows.Forms.DateTimePicker Day_Time_Picker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Panel_Matrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BT_Sunday;
        private System.Windows.Forms.Button BT_Saturday;
        private System.Windows.Forms.Button BT_Friday;
        private System.Windows.Forms.Button BT_Thursday;
        private System.Windows.Forms.Button BT_Wenesday;
        private System.Windows.Forms.Button BT_Tuesday;
        private System.Windows.Forms.Button BT_Monday;
        private System.Windows.Forms.NumericUpDown NUD_Notify;
        private System.Windows.Forms.CheckBox CB_Notify;
        private System.Windows.Forms.Button BT_Last;
        private System.Windows.Forms.Button BT_Next;
    }
}

