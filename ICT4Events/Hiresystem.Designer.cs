namespace ICT4Events
{
    partial class Hiresystem
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SearchTxtHR = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRFIDinfoUser = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BttngetInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.RFIDtext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblconnectedInfo = new System.Windows.Forms.Label();
            this.lblserialInfo = new System.Windows.Forms.Label();
            this.bttnEnableRFID = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SearchTxtHR);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 91);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search item:";
            // 
            // SearchTxtHR
            // 
            this.SearchTxtHR.Location = new System.Drawing.Point(9, 29);
            this.SearchTxtHR.Name = "SearchTxtHR";
            this.SearchTxtHR.Size = new System.Drawing.Size(193, 22);
            this.SearchTxtHR.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRFIDinfoUser);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(953, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 523);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User info:";
            // 
            // lblRFIDinfoUser
            // 
            this.lblRFIDinfoUser.AutoSize = true;
            this.lblRFIDinfoUser.Location = new System.Drawing.Point(105, 31);
            this.lblRFIDinfoUser.Name = "lblRFIDinfoUser";
            this.lblRFIDinfoUser.Size = new System.Drawing.Size(18, 17);
            this.lblRFIDinfoUser.TabIndex = 5;
            this.lblRFIDinfoUser.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Birth Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "RFID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BttngetInfo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblWaiting);
            this.groupBox2.Controls.Add(this.RFIDtext);
            this.groupBox2.Location = new System.Drawing.Point(953, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 126);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RFID TAG:";
            // 
            // BttngetInfo
            // 
            this.BttngetInfo.Location = new System.Drawing.Point(108, 67);
            this.BttngetInfo.Name = "BttngetInfo";
            this.BttngetInfo.Size = new System.Drawing.Size(124, 34);
            this.BttngetInfo.TabIndex = 5;
            this.BttngetInfo.Text = "GET INFO";
            this.BttngetInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scanned tag:";
            // 
            // lblWaiting
            // 
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Location = new System.Drawing.Point(6, 106);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(0, 17);
            this.lblWaiting.TabIndex = 4;
            // 
            // RFIDtext
            // 
            this.RFIDtext.Location = new System.Drawing.Point(108, 39);
            this.RFIDtext.Name = "RFIDtext";
            this.RFIDtext.Size = new System.Drawing.Size(188, 22);
            this.RFIDtext.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(822, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "connected:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(822, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Serial:";
            // 
            // lblconnectedInfo
            // 
            this.lblconnectedInfo.AutoSize = true;
            this.lblconnectedInfo.Location = new System.Drawing.Point(917, 84);
            this.lblconnectedInfo.Name = "lblconnectedInfo";
            this.lblconnectedInfo.Size = new System.Drawing.Size(18, 17);
            this.lblconnectedInfo.TabIndex = 20;
            this.lblconnectedInfo.Text = "--";
            // 
            // lblserialInfo
            // 
            this.lblserialInfo.AutoSize = true;
            this.lblserialInfo.Location = new System.Drawing.Point(917, 59);
            this.lblserialInfo.Name = "lblserialInfo";
            this.lblserialInfo.Size = new System.Drawing.Size(18, 17);
            this.lblserialInfo.TabIndex = 19;
            this.lblserialInfo.Text = "--";
            // 
            // bttnEnableRFID
            // 
            this.bttnEnableRFID.Location = new System.Drawing.Point(823, 12);
            this.bttnEnableRFID.Name = "bttnEnableRFID";
            this.bttnEnableRFID.Size = new System.Drawing.Size(124, 34);
            this.bttnEnableRFID.TabIndex = 18;
            this.bttnEnableRFID.Text = "Enable RFID";
            this.bttnEnableRFID.UseVisualStyleBackColor = true;
            this.bttnEnableRFID.Click += new System.EventHandler(this.bttnEnableRFID_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Product on user:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(695, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, 693);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 693);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Hire price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 693);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Bail price:";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(12, 150);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(935, 212);
            this.listBox3.TabIndex = 25;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(698, 385);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(249, 292);
            this.listBox2.TabIndex = 24;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 385);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(680, 292);
            this.listBox1.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(953, 683);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 50);
            this.button2.TabIndex = 31;
            this.button2.Text = "LEND";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Hiresystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 746);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblconnectedInfo);
            this.Controls.Add(this.lblserialInfo);
            this.Controls.Add(this.bttnEnableRFID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "Hiresystem";
            this.Text = "Hiresystem";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox SearchTxtHR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblRFIDinfoUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BttngetInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWaiting;
        private System.Windows.Forms.TextBox RFIDtext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblconnectedInfo;
        private System.Windows.Forms.Label lblserialInfo;
        private System.Windows.Forms.Button bttnEnableRFID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}