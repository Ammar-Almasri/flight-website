using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ammarinho_s_Airlines
{
    public partial class frmOnlineCheckin : Form
    {
        private frmBook parent;
        public frmOnlineCheckin(frmBook parent)
        {
            InitializeComponent();
            this.parent = parent;

        }
        void makeControlsVisible()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = true;
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (parent.passportno != txtboxpaspno.Text)
            {
                MessageBox.Show("Passport not found.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else makeControlsVisible();
        }
        string getSeat()
        {
            foreach (System.Windows.Forms.RadioButton radioButton in this.Controls.OfType<System.Windows.Forms.RadioButton>())
            {
                if (radioButton.Checked)
                {
                    return radioButton.Tag.ToString();
                }
            }
            return null;
        }
        private void DisableControls()
        {
            foreach (Control control in this.Controls)
            {
                if(control != btnViewTckt)
                control.Enabled = false;
            }
        }
        private void checkin_Click(object sender, EventArgs e)
        {
            parent.seatno = getSeat();
            DisableControls();
        }

        private void btnViewTckt_Click(object sender, EventArgs e)
        {
            parent.btnViewTckt_Click(sender, e);
        }
    }
}
