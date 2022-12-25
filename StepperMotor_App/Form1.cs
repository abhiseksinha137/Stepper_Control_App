using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StepperMotor_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the default baudrate
            commStage.baudrate = 115200;
            txtBxCurrent.Text = Properties.Settings.Default.pos;
            enableWarningToolStripMenuItem.Checked = Properties.Settings.Default.enableWarning;

            // Disable Resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void moveTo(int target)
        {
            int current = int.Parse(txtBxCurrent.Text);
            int steps = target - current;
            moveStage(steps);
        }
        void moveStage(int steps)
        {
            if (commStage.com.IsOpen)
            {
                commStage.sendSerial(steps.ToString());
                int currentPos = int.Parse(Properties.Settings.Default.pos) + steps;
                Properties.Settings.Default.pos = currentPos.ToString();
                Properties.Settings.Default.Save();
                txtBxCurrent.Text = Properties.Settings.Default.pos;
            }
            else
               if (enableWarningToolStripMenuItem.Checked)
                MessageBox.Show("Connection to COM port unavailable");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int rel;
            bool isNum = int.TryParse(txtBxMoveRel.Text, out rel);
            if (isNum)
            {
                moveStage(Math.Abs(rel));
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int rel;
            bool isNum = int.TryParse(txtBxMoveRel.Text, out rel);
            if (isNum)
            {
                moveStage(-Math.Abs(rel));
            }
        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            int target;
            
            bool isNum = int.TryParse(txtBxTarget.Text, out target);
            if (isNum)
            {
                moveTo(target);
            }
        }

        private void txtBxTarget_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBxTarget_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGo.PerformClick();
            }
        }

        private void tare()
        {
            Properties.Settings.Default.pos = "0";
            txtBxCurrent.Text = Properties.Settings.Default.pos;
        }

        private void tareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tare();
        }

        private void enableWarningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool state = enableWarningToolStripMenuItem.Checked;
            setEnableWarningToolStrip(!state);
        }
        public void setEnableWarningToolStrip(bool target)
        {
            enableWarningToolStripMenuItem.Checked = target;
            Properties.Settings.Default.enableWarning = target;
            Properties.Settings.Default.Save();
        }

        public void setBaudrate()
        {
            formBaudrate frm = new formBaudrate();
            frm.ShowDialog();
        }

        private void setBaudrateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setBaudrate();
        }
    }
}
