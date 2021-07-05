using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;

namespace Win11Check
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            //CPU
            SelectQuery Sq = new SelectQuery("Win32_Processor");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            //StringBuilder sb = new StringBuilder();

            foreach (ManagementObject mo in osDetailsCollection)
            {
                labelCPU.Text = (string)mo["Name"];
            }

            //RAM
            ManagementObjectSearcher Search = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject Mobject in Search.Get())
            {
                double totalRam = Math.Round(Convert.ToDouble(Mobject["TotalPhysicalMemory"]) / (1024 * 1024 * 1024));
                labelRam.Text = String.Format("{0} GB", totalRam);
            }

            //Drive
            DriveInfo CDrive = new DriveInfo("C");
            labelStorage.Text = String.Format("{0} GB", Math.Round(Convert.ToDouble(CDrive.TotalSize / (1024 * 1024 * 1024))));

            //secure boot
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();

            PowerShell ps = PowerShell.Create(); // Create a new PowerShell instance
            ps.Runspace = runspace; // Add the instance to the runspace
            ps.Commands.AddScript("Confirm-SecureBootUEFI"); // Add a script
            //ps.Commands.AddStatement().AddScript("Invoke-Command -Computer server2 -ScriptBlock {ipconfig}"); // Add a second statement and add another script to it
            Collection<PSObject> results = ps.Invoke();

            runspace.Close();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject obj in results)
            {
                labelFirm.Text = (obj.ToString());
            }
        }
    }
}
