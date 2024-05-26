namespace Ammarinho_s_Airlines
{
    partial class frmCancelFlight
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFlightno = new System.Windows.Forms.Label();
            this.txtboxticketno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Modern No. 20", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(276, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(249, 45);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel Flight";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFlightno
            // 
            this.lblFlightno.AutoSize = true;
            this.lblFlightno.BackColor = System.Drawing.Color.LightGray;
            this.lblFlightno.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightno.ForeColor = System.Drawing.Color.Black;
            this.lblFlightno.Location = new System.Drawing.Point(140, 185);
            this.lblFlightno.Name = "lblFlightno";
            this.lblFlightno.Size = new System.Drawing.Size(269, 34);
            this.lblFlightno.TabIndex = 30;
            this.lblFlightno.Text = "Enter flight number :";
            // 
            // txtboxticketno
            // 
            this.txtboxticketno.Location = new System.Drawing.Point(426, 194);
            this.txtboxticketno.MaxLength = 4;
            this.txtboxticketno.Name = "txtboxticketno";
            this.txtboxticketno.Size = new System.Drawing.Size(157, 22);
            this.txtboxticketno.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 41);
            this.label1.TabIndex = 32;
            this.label1.Text = "Flight Cancellation";
            // 
            // frmCancelFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblFlightno);
            this.Controls.Add(this.txtboxticketno);
            this.Name = "frmCancelFlight";
            this.Text = "frmCancelFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFlightno;
        private System.Windows.Forms.TextBox txtboxticketno;
        private System.Windows.Forms.Label label1;
    }
}