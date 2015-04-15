namespace ICT4Events
{
    partial class FormBasicGUI
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCategorie = new System.Windows.Forms.Button();
            this.btnTags = new System.Windows.Forms.Button();
            this.btnMateriaalHuren = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblIngelogdNaam = new System.Windows.Forms.Label();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNewsFeed = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Wheat;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnHome.Location = new System.Drawing.Point(0, 14);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(89, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnCategorie
            // 
            this.btnCategorie.BackColor = System.Drawing.Color.Wheat;
            this.btnCategorie.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorie.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCategorie.Location = new System.Drawing.Point(95, 14);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Size = new System.Drawing.Size(89, 23);
            this.btnCategorie.TabIndex = 1;
            this.btnCategorie.Text = "Categorie";
            this.btnCategorie.UseVisualStyleBackColor = false;
            // 
            // btnTags
            // 
            this.btnTags.BackColor = System.Drawing.Color.Wheat;
            this.btnTags.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTags.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnTags.Location = new System.Drawing.Point(190, 14);
            this.btnTags.Name = "btnTags";
            this.btnTags.Size = new System.Drawing.Size(89, 23);
            this.btnTags.TabIndex = 2;
            this.btnTags.Text = "Tags";
            this.btnTags.UseVisualStyleBackColor = false;
            // 
            // btnMateriaalHuren
            // 
            this.btnMateriaalHuren.BackColor = System.Drawing.Color.Wheat;
            this.btnMateriaalHuren.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriaalHuren.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnMateriaalHuren.Location = new System.Drawing.Point(285, 14);
            this.btnMateriaalHuren.Name = "btnMateriaalHuren";
            this.btnMateriaalHuren.Size = new System.Drawing.Size(134, 23);
            this.btnMateriaalHuren.TabIndex = 3;
            this.btnMateriaalHuren.Text = "Materiaal Huren";
            this.btnMateriaalHuren.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(585, 16);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(691, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 20);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "S";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblIngelogdNaam
            // 
            this.lblIngelogdNaam.AutoSize = true;
            this.lblIngelogdNaam.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngelogdNaam.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblIngelogdNaam.Location = new System.Drawing.Point(837, 18);
            this.lblIngelogdNaam.Name = "lblIngelogdNaam";
            this.lblIngelogdNaam.Size = new System.Drawing.Size(128, 16);
            this.lblIngelogdNaam.TabIndex = 6;
            this.lblIngelogdNaam.Text = "Laurent de Vries";
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BackColor = System.Drawing.Color.Maroon;
            this.pbProfilePicture.Location = new System.Drawing.Point(781, 4);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(50, 45);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePicture.TabIndex = 7;
            this.pbProfilePicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pbProfilePicture);
            this.panel1.Controls.Add(this.btnMateriaalHuren);
            this.panel1.Controls.Add(this.lblIngelogdNaam);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnCategorie);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.btnTags);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 49);
            this.panel1.TabIndex = 8;
            // 
            // pnlNewsFeed
            // 
            this.pnlNewsFeed.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnlNewsFeed.Location = new System.Drawing.Point(137, 51);
            this.pnlNewsFeed.Name = "pnlNewsFeed";
            this.pnlNewsFeed.Size = new System.Drawing.Size(729, 395);
            this.pnlNewsFeed.TabIndex = 10;
            // 
            // FormBasicGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(976, 513);
            this.Controls.Add(this.pnlNewsFeed);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(992, 552);
            this.Name = "FormBasicGUI";
            this.Text = "Basic user interface";
            this.Resize += new System.EventHandler(this.FormBasicGUI_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCategorie;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Button btnMateriaalHuren;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblIngelogdNaam;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNewsFeed;
    }
}

