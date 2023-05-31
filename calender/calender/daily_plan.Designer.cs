namespace calender
{
    partial class daily_plan
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
            this.Panel_Note = new System.Windows.Forms.Panel();
            this.Date_Time_Picker_DP = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MS_Item_Add_Note = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Item_Today = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_Next = new System.Windows.Forms.Button();
            this.BT_Last = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BT_Last);
            this.panel1.Controls.Add(this.BT_Next);
            this.panel1.Controls.Add(this.Date_Time_Picker_DP);
            this.panel1.Controls.Add(this.Panel_Note);
            this.panel1.Location = new System.Drawing.Point(13, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 687);
            this.panel1.TabIndex = 0;
            // 
            // Panel_Note
            // 
            this.Panel_Note.Location = new System.Drawing.Point(3, 38);
            this.Panel_Note.Name = "Panel_Note";
            this.Panel_Note.Size = new System.Drawing.Size(957, 643);
            this.Panel_Note.TabIndex = 0;
            // 
            // Date_Time_Picker_DP
            // 
            this.Date_Time_Picker_DP.Location = new System.Drawing.Point(395, 7);
            this.Date_Time_Picker_DP.Name = "Date_Time_Picker_DP";
            this.Date_Time_Picker_DP.Size = new System.Drawing.Size(238, 22);
            this.Date_Time_Picker_DP.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Item_Add_Note,
            this.MS_Item_Today});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MS_Item_Add_Note
            // 
            this.MS_Item_Add_Note.Name = "MS_Item_Add_Note";
            this.MS_Item_Add_Note.Size = new System.Drawing.Size(96, 24);
            this.MS_Item_Add_Note.Text = "ADD NOTE";
            // 
            // MS_Item_Today
            // 
            this.MS_Item_Today.Name = "MS_Item_Today";
            this.MS_Item_Today.Size = new System.Drawing.Size(69, 24);
            this.MS_Item_Today.Text = "TODAY";
            // 
            // BT_Next
            // 
            this.BT_Next.Location = new System.Drawing.Point(675, 9);
            this.BT_Next.Name = "BT_Next";
            this.BT_Next.Size = new System.Drawing.Size(107, 23);
            this.BT_Next.TabIndex = 2;
            this.BT_Next.Text = "NEXT DAY";
            this.BT_Next.UseVisualStyleBackColor = true;
            // 
            // BT_Last
            // 
            this.BT_Last.Location = new System.Drawing.Point(257, 9);
            this.BT_Last.Name = "BT_Last";
            this.BT_Last.Size = new System.Drawing.Size(103, 23);
            this.BT_Last.TabIndex = 3;
            this.BT_Last.Text = "LAST DAY";
            this.BT_Last.UseVisualStyleBackColor = true;
            // 
            // daily_plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "daily_plan";
            this.Text = "daily_plan";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker Date_Time_Picker_DP;
        private System.Windows.Forms.Panel Panel_Note;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Item_Add_Note;
        private System.Windows.Forms.ToolStripMenuItem MS_Item_Today;
        private System.Windows.Forms.Button BT_Last;
        private System.Windows.Forms.Button BT_Next;
    }
}