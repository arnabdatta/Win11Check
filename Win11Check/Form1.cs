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

namespace Win11Check
{
    public partial class Form1 : Form
    {
        public Form1()
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
            SelectQuery Sq = new SelectQuery("Win32_Processor");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            //StringBuilder sb = new StringBuilder();

            foreach (ManagementObject mo in osDetailsCollection)
            {
                labelCPU.Text = (string)mo["Name"];
            }

            ManagementObjectSearcher Search = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject Mobject in Search.Get())
            {
                double totalRam = Math.Round(Convert.ToDouble(Mobject["TotalPhysicalMemory"]) / (1024 * 1024 * 1024));
                labelRam.Text = String.Format("{0} GB", totalRam);
            }
        }
    }
}
