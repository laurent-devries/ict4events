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
    public partial class ReserveringSysteem : Form
    {
        public ReserveringSysteem()
        {
            InitializeComponent();
        }

        private void cbEvents_DropDown(object sender, EventArgs e)
        {
            EventManager eventManager = new EventManager();
            List<Event> eventList = eventManager.RequestEvent();

            foreach (Event ev in eventList)
            {
                cbEvents.Items.Add(ev);
            }
        }
    }
}
