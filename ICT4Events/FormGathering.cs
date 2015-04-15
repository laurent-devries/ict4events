using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Events
{
    public partial class FormGathering : Form
    {
        public FormGathering()
        {
            InitializeComponent();
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            SocialSharing s = new SocialSharing();
            s.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        
        }
    }
}
