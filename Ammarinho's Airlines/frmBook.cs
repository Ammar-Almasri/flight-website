using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ammarinho_s_Airlines
{ 
    public partial class frmBook : Form
    {
        
        public byte guests = 1;
        float total = 0, guestprice = 160, bagprice = 6.33f, hbagprice = 3.25f;
        private Random rand = new Random(); 
        public string ticketno;
        public DateTime departure = DateTime.Now;
        public DateTime returnn = DateTime.Now;
        public string passportno = null;
        public string seatno = "";
        public frmBook()
        {
            InitializeComponent();
            
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            comboBoxFrom.Text = comboBoxFrom.Items[0].ToString();
            comboBoxTo.Text = comboBoxTo.Items[0].ToString();
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MinDate = DateTime.Now;

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;

        }

        private void DisableControlsInTab(TabPage tabPage)
        {
            foreach (Control control in tabPage.Controls)
            {
                control.Enabled = false;
            }
        }
        private void EnableControlsInTab(TabPage tabPage)
        {
            foreach (Control control in tabPage.Controls)
            {
                control.Enabled = true;
            }
        }
        private void btnDoneTrip_Click_1(object sender, EventArgs e)
        {
            DisableControlsInTab(tabTripInfo);
            total += (float)noOfGuests.Value * guestprice;
            lblMoney.Text = total.ToString() + " JOD";
            noOfBags.Maximum = noOfGuests.Value;
            noOfHandBags.Maximum = noOfGuests.Value * 2;
            departure = dateTimePicker1.Value;
            returnn = dateTimePicker2.Value;
        }
        private void checkIfDone()
        {
            
            if (btnDoneTrip.Enabled == true && tab.SelectedTab == tabPersonal)
            {
                MessageBox.Show("You must complete Trip Info first. ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisableControlsInTab(tabPersonal);  

            }
            if ((btnDoneTrip.Enabled == true
                || btnDoneBaggage.Enabled == true
                || btnDonePersonal.Enabled == true)
                && tab.SelectedTab == tabPayment)
            {
                MessageBox.Show("You must complete ALL previous steps before paying. ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisableControlsInTab(tabPayment);

            }
            else if(txtBoxCVV.Text == string.Empty)EnableControlsInTab(tabPayment);
            if ((btnDoneTrip.Enabled == true
                || btnDonePersonal.Enabled == true)
                && tab.SelectedTab == tabBaggage)
            {
                MessageBox.Show("You must complete ALL previous steps before paying. ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisableControlsInTab(tabBaggage);

            }
            else if(chkboxprohibited.Checked == false)EnableControlsInTab(tabBaggage);
            if (btnDoneTrip.Enabled == false && txtboxFName.Text == string.Empty)
                EnableControlsInTab(tabPersonal);

        }
        void updateTextGuests()
        {
            lblFname.Text = $"Guest({guests}) " + "First Name* : ";
            lblLName.Text = $"Guest({guests}) " + "Last Name* : ";
        }
        private void tab_MouseDown(object sender, MouseEventArgs e)
        {
            checkIfDone();
            if (noOfGuests.Value > 1)
            {
                updateTextGuests();
            }
        }

        void giveError(Control control)
        {
            errorProvider1.SetError(control, "You MUST fill this to proceed.");
        }
        bool checkAlltxtBoxFilled(TabPage tabPage)
        {
            bool allFilled = true;
            foreach (Control txtbox in tabPage.Controls)
            {
                if (txtbox != txtBoxAge && txtbox != progressBar1)
                    if (txtbox.Text == string.Empty) {
                        giveError(txtbox);
                        allFilled = false;
                    }
            }
            return allFilled;
        }
        void clearAllTextBoxes(TabPage tabControl)
        {
            foreach (Control control in tabControl.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)control).Text = string.Empty;
                }
            }
        }
        void moveNext(TabPage tabPage)
        {
            errorProvider1.Clear();
            if (checkAlltxtBoxFilled(tabPage))
            {
                if (guests < noOfGuests.Value)
                {
                    guests++;
                    updateTextGuests();
                    clearAllTextBoxes(tabPage);
                }
                else
                {
                    DisableControlsInTab(tabPage);
                }
            }
            
        }

        private void btnbook_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (checkAlltxtBoxFilled(tabPayment))
            {
                timer1.Start();
                progressBar1.Visible = true;           
                DisableControlsInTab(tabPayment);
                btnViewTckt.Visible = true;
                btnViewTckt.Enabled = true;
                ticketno = "A" + rand.Next(100, 301);
                passportno = txtboxPNum.Text;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value == 100)
            {
                timer1.Stop(); // Stop the timer when progress reaches 100%
                MessageBox.Show("Trip booked Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else progressBar1.Value += 10;
        }

        public void btnViewTckt_Click(object sender, EventArgs e)
        {
           
            FrmTicket frm = new FrmTicket(this);
            frm.Show();
        }

        private void btnDonePersonal_Click(object sender, EventArgs e)
        {  
            moveNext(tabPersonal);
        }

        private void btnDoneBaggage_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (chkboxprohibited.Checked)
            {
                DisableControlsInTab(tabBaggage);
                total += (float)noOfBags.Value * bagprice;
                total += (float)noOfHandBags.Value * hbagprice;
                lblMoney.Text = total.ToString() + " JOD";
            }
            else giveError(chkboxprohibited);
        }

        private void txtboxCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((txtboxCardNo.TextLength+1) %5 == 0)
            if (e.KeyChar != (char)Keys.Back)
            {
                txtboxCardNo.AppendText(" ");
                e.Handled = true; // Suppress the key press event
            }
        }
    }
}
