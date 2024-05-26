using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Ammarinho_s_Airlines
{
    public partial class frmCancelFlight : Form
    {
        private frmBook parent;
        public frmCancelFlight(frmBook parent)
        {
            InitializeComponent();
            this.parent = parent;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtboxticketno.Text == parent.ticketno)
            {
                DisableControls();
                parent.ticketno = null;
                MessageBox.Show("Flight Cancelled successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Flight number NOT found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        
        private void DisableControls()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
        }
    }
}
