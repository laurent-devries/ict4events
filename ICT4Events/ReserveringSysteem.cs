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
    public partial class Reservering_systeem : Form
    {
        public Reservering_systeem()
        {
            InitializeComponent();
            Event eventData = new Event();
            List<Event> events = eventData.RequestEvent();
        }
    }
}
