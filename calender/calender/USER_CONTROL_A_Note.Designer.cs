namespace calender
{
    partial class USER_CONTROL_A_Note
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_Note = new System.Windows.Forms.TextBox();
            this.CB_Done = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NUD_To_Minutes = new System.Windows.Forms.NumericUpDown();
            this.NUD_To_Hours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NMD_Minutes = new System.Windows.Forms.NumericUpDown();
            this.NUD_Hours = new System.Windows.Forms.NumericUpDown();
            this.CBB_Status = new System.Windows.Forms.ComboBox();
            this.BT_Fix = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_To_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_To_Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMD_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Hours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TB_Note);
            this.panel1.Controls.Add(this.CB_Done);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 48);
            this.panel1.TabIndex = 0;
            // 
            // TB_Note
            // 
            this.TB_Note.Location = new System.Drawing.Point(28, 11);
            this.TB_Note.Name = "TB_Note";
            this.TB_Note.Size = new System.Drawing.Size(408, 22);
            this.TB_Note.TabIndex = 1;
            // 
            // CB_Done
            // 
            this.CB_Done.AutoSize = true;
            this.CB_Done.Location = new System.Drawing.Point(4, 15);
            this.CB_Done.Name = "CB_Done";
            this.CB_Done.Size = new System.Drawing.Size(18, 17);
            this.CB_Done.TabIndex = 0;
            this.CB_Done.UseVisualStyleBackColor = true;
            this.CB_Done.CheckedChanged += new System.EventHandler(this.CB_Done_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NUD_To_Minutes);
            this.panel2.Controls.Add(this.NUD_To_Hours);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.NMD_Minutes);
            this.panel2.Controls.Add(this.NUD_Hours);
            this.panel2.Location = new System.Drawing.Point(449, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 48);
            this.panel2.TabIndex = 1;
            // 
            // NUD_To_Minutes
            // 
            this.NUD_To_Minutes.Location = new System.Drawing.Point(171, 12);
            this.NUD_To_Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUD_To_Minutes.Name = "NUD_To_Minutes";
            this.NUD_To_Minutes.Size = new System.Drawing.Size(37, 22);
            this.NUD_To_Minutes.TabIndex = 4;
            // 
            // NUD_To_Hours
            // 
            this.NUD_To_Hours.Location = new System.Drawing.Point(125, 12);
            this.NUD_To_Hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NUD_To_Hours.Name = "NUD_To_Hours";
            this.NUD_To_Hours.Size = new System.Drawing.Size(40, 22);
            this.NUD_To_Hours.TabIndex = 3;
            this.NUD_To_Hours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "TO";
            // 
            // NMD_Minutes
            // 
            this.NMD_Minutes.Location = new System.Drawing.Point(50, 12);
            this.NMD_Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NMD_Minutes.Name = "NMD_Minutes";
            this.NMD_Minutes.Size = new System.Drawing.Size(37, 22);
            this.NMD_Minutes.TabIndex = 1;
            // 
            // NUD_Hours
            // 
            this.NUD_Hours.Location = new System.Drawing.Point(4, 12);
            this.NUD_Hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NUD_Hours.Name = "NUD_Hours";
            this.NUD_Hours.Size = new System.Drawing.Size(40, 22);
            this.NUD_Hours.TabIndex = 0;
            this.NUD_Hours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CBB_Status
            // 
            this.CBB_Status.FormattingEnabled = true;
            this.CBB_Status.Location = new System.Drawing.Point(672, 17);
            this.CBB_Status.Name = "CBB_Status";
            this.CBB_Status.Size = new System.Drawing.Size(121, 24);
            this.CBB_Status.TabIndex = 2;
            // 
            // BT_Fix
            // 
            this.BT_Fix.Location = new System.Drawing.Point(800, 20);
            this.BT_Fix.Name = "BT_Fix";
            this.BT_Fix.Size = new System.Drawing.Size(42, 23);
            this.BT_Fix.TabIndex = 3;
            this.BT_Fix.Text = "FIX";
            this.BT_Fix.UseVisualStyleBackColor = true;
            this.BT_Fix.Click += new System.EventHandler(this.BT_Fix_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(848, 20);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(46, 23);
            this.BT_Delete.TabIndex = 4;
            this.BT_Delete.Text = "DEL";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // USER_CONTROL_A_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.BT_Fix);
            this.Controls.Add(this.CBB_Status);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "USER_CONTROL_A_Note";
            this.Size = new System.Drawing.Size(903, 54);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_To_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_To_Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMD_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Hours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_Note;
        private System.Windows.Forms.CheckBox CB_Done;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown NMD_Minutes;
        private System.Windows.Forms.NumericUpDown NUD_Hours;
        private System.Windows.Forms.NumericUpDown NUD_To_Minutes;
        private System.Windows.Forms.NumericUpDown NUD_To_Hours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBB_Status;
        private System.Windows.Forms.Button BT_Fix;
        private System.Windows.Forms.Button BT_Delete;
    }
}
