using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysScanner
{
    public partial class Scanner : Form
    {
        public Scanner()
        {
            InitializeComponent();
        }

        private void chkWorkgroup_CheckedChanged(object sender, EventArgs e)
        {
            pnlWorkgroup.Enabled = (sender as CheckBox).Checked;
        }

        private void chkDomain_CheckedChanged(object sender, EventArgs e)
        {
            pnlDomain.Enabled = (sender as CheckBox).Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(chkDomain.Checked && (txtDomain.Text.Trim() == string.Empty || txtDomainUsername.Text.Trim() == string.Empty || txtDomainPassword.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Please Enter Domain Credential.","Error");
                return;
            }
            if (chkWorkgroup.Checked && (txtWrkPassword.Text.Trim() == string.Empty || txtWrkUsername.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Please Enter Workgroup Credential.");
            }

            var x = Utility.VisibleComputers();
            foreach (var machine in x)
            {
                try
                {
                    dataGridView1.DataSource = HardwareInfo.GetHardwareInfo( machine, machine,txtWrkUsername.Text,txtWrkPassword.Text);
                }
                catch (Exception ex)
                {

                  
                }
                
            }
            //machineBindingSource.Add(new Machine {MachineName=Utility.GetJoinedDomain() });


        }
    }
}
