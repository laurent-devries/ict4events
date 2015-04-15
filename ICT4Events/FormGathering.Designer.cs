namespace ICT4Events
{
    partial class FormGathering
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSocial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(59, 48);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(165, 30);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login system";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSocial
            // 
            this.btnSocial.Location = new System.Drawing.Point(59, 12);
            this.btnSocial.Name = "btnSocial";
            this.btnSocial.Size = new System.Drawing.Size(165, 30);
            this.btnSocial.TabIndex = 1;
            this.btnSocial.Text = "Social sharing system";
            this.btnSocial.UseVisualStyleBackColor = true;
            this.btnSocial.Click += new System.EventHandler(this.btnSocial_Click);
            // 
            // FormGathering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSocial);
            this.Controls.Add(this.btnLogin);
            this.Name = "FormGathering";
            this.Text = "FormGathering";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSocial;
    }
}