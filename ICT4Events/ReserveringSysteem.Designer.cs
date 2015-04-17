namespace ICT4Events
{
    partial class ReserveringSysteem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAankomst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEvents = new System.Windows.Forms.ComboBox();
            this.dtpAankomst = new System.Windows.Forms.DateTimePicker();
            this.dtpVertrek = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ICT4Events.Properties.Resources.Camping_ReeënDal;
            this.pictureBox1.Location = new System.Drawing.Point(341, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1044, 862);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kies een event:";
            // 
            // lblAankomst
            // 
            this.lblAankomst.AutoSize = true;
            this.lblAankomst.Location = new System.Drawing.Point(12, 53);
            this.lblAankomst.Name = "lblAankomst";
            this.lblAankomst.Size = new System.Drawing.Size(57, 13);
            this.lblAankomst.TabIndex = 2;
            this.lblAankomst.Text = "Aankomst:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vertrek:";
            // 
            // cbEvents
            // 
            this.cbEvents.FormattingEnabled = true;
            this.cbEvents.Location = new System.Drawing.Point(113, 29);
            this.cbEvents.Name = "cbEvents";
            this.cbEvents.Size = new System.Drawing.Size(121, 21);
            this.cbEvents.TabIndex = 4;
            this.cbEvents.DropDown += new System.EventHandler(this.cbEvents_DropDown);
            // 
            // dtpAankomst
            // 
            this.dtpAankomst.Location = new System.Drawing.Point(113, 53);
            this.dtpAankomst.Name = "dtpAankomst";
            this.dtpAankomst.Size = new System.Drawing.Size(200, 20);
            this.dtpAankomst.TabIndex = 5;
            // 
            // dtpVertrek
            // 
            this.dtpVertrek.Location = new System.Drawing.Point(113, 79);
            this.dtpVertrek.Name = "dtpVertrek";
            this.dtpVertrek.Size = new System.Drawing.Size(200, 20);
            this.dtpVertrek.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kies een plaats:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // ReserveringSysteem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 819);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpVertrek);
            this.Controls.Add(this.dtpAankomst);
            this.Controls.Add(this.cbEvents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAankomst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReserveringSysteem";
            this.Text = "ReserveringSysteem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAankomst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEvents;
        private System.Windows.Forms.DateTimePicker dtpAankomst;
        private System.Windows.Forms.DateTimePicker dtpVertrek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}