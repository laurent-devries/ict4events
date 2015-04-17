namespace ICT4Events
{
    partial class Reservering_systeem
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
            this.cbEvents = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAankomst = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpVertrek = new System.Windows.Forms.DateTimePicker();
            this.cbBeschickbarePlaatsen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEvents
            // 
            this.cbEvents.FormattingEnabled = true;
            this.cbEvents.Location = new System.Drawing.Point(148, 12);
            this.cbEvents.Name = "cbEvents";
            this.cbEvents.Size = new System.Drawing.Size(121, 21);
            this.cbEvents.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ICT4Events.Properties.Resources.Camping_ReeënDal;
            this.pictureBox1.Location = new System.Drawing.Point(438, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(973, 706);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecteer event:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecteer plaats";
            // 
            // dtpAankomst
            // 
            this.dtpAankomst.Location = new System.Drawing.Point(148, 84);
            this.dtpAankomst.Name = "dtpAankomst";
            this.dtpAankomst.Size = new System.Drawing.Size(200, 20);
            this.dtpAankomst.TabIndex = 4;
            this.dtpAankomst.Value = new System.DateTime(2015, 4, 17, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aankomst";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vertrek";
            // 
            // dtpVertrek
            // 
            this.dtpVertrek.Location = new System.Drawing.Point(148, 117);
            this.dtpVertrek.Name = "dtpVertrek";
            this.dtpVertrek.Size = new System.Drawing.Size(200, 20);
            this.dtpVertrek.TabIndex = 7;
            this.dtpVertrek.Value = new System.DateTime(2015, 4, 17, 0, 0, 0, 0);
            // 
            // cbBeschickbarePlaatsen
            // 
            this.cbBeschickbarePlaatsen.FormattingEnabled = true;
            this.cbBeschickbarePlaatsen.Location = new System.Drawing.Point(148, 151);
            this.cbBeschickbarePlaatsen.Name = "cbBeschickbarePlaatsen";
            this.cbBeschickbarePlaatsen.Size = new System.Drawing.Size(121, 21);
            this.cbBeschickbarePlaatsen.TabIndex = 8;
            // 
            // Reservering_systeem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 798);
            this.Controls.Add(this.cbBeschickbarePlaatsen);
            this.Controls.Add(this.dtpVertrek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpAankomst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbEvents);
            this.Name = "Reservering_systeem";
            this.Text = "Reservering_systeem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEvents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAankomst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpVertrek;
        private System.Windows.Forms.ComboBox cbBeschickbarePlaatsen;
    }
}