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
    public partial class frmPostpone : Form
    {
        private frmBook parent;
        public frmPostpone(frmBook parent)
        {
            InitializeComponent();
            this.parent = parent;

        }

        private void frmPostpone_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = parent.departure;
            dateTimePicker2.MinDate = parent.returnn;
        }

        void makeControlsVisible()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = true;
            }
        }
        void makeControlsInVisible()
        {
            foreach (Control control in this.Controls)
            {
                if (control == txtboxticketno || control == lblFlightno
                    || control == btnSearch || control == lbltitle)
                    continue;
                else control.Visible = false;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtboxticketno.Text == parent.ticketno)
            {
                makeControlsVisible();
            }
            else
            {
                MessageBox.Show("Flight number NOT found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                makeControlsInVisible();
            }
        }
        private void DisableControls()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            DisableControls();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void lblFlightno_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ok");
        }

        private void txtboxticketno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
