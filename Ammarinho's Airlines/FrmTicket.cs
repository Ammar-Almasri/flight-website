using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ammarinho_s_Airlines
{
    public partial class FrmTicket : Form
    {
        private frmBook parent;
        public FrmTicket(frmBook parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FrmTicket_Load(object sender, EventArgs e)
        {
            lblTicketInfo.Text = "Guests : " + parent.guests;
            lblTicketInfo.Text += "\nDeparture : " + parent.departure.ToShortDateString()
                + " " + parent.comboBoxFrom.Text.ToString() +
           "\nReturn :      " + parent.returnn.ToShortDateString() + " " + parent.comboBoxTo.Text.ToString()
           + "\nTicket Number : " + parent.ticketno
           +"\nSeat Number : " + parent.seatno;
        }
    }
}
