using System;
using System.Drawing;
using System.IO;
using System.Management;
using System.Windows.Forms;

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

                int maxClockSpeed =  Int32.Parse(mo["MaxClockSpeed"].ToString());
                if (maxClockSpeed > 1000)
                {
                    pictureBoxCPU.Image = Properties.Resources.complete;
                }
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
            //Runspace runspace = RunspaceFactory.CreateRunspace();
            //runspace.Open();

            //PowerShell ps = PowerShell.Create(); // Create a new PowerShell instance
            //ps.Runspace = runspace; // Add the instance to the runspace
            //ps.Commands.AddScript("Confirm-SecureBootUEFI"); // Add a script
            ////ps.Commands.AddStatement().AddScript("Invoke-Command -Computer server2 -ScriptBlock {ipconfig}"); // Add a second statement and add another script to it
            //Collection<PSObject> results = ps.Invoke();

            //runspace.Close();

            //StringBuilder stringBuilder = new StringBuilder();
            //foreach (PSObject obj in results)
            //{
            //    labelFirm.Text = (obj.ToString());
            //}

            int rc = 0;
            string key = @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\SecureBoot\State";
            string subkey = @"UEFISecureBootEnabled";
            try
            {
                object value = Microsoft.Win32.Registry.GetValue(key, subkey, rc);
                if (value != null)
                    rc = (int)value;
            }
            catch { }
            //Console.WriteLine($@"{subkey} is {(rc >= 1 ? "On" : "Off")} ({rc.ToString()})");
            if (rc >= 1)
                labelFirm.Text = "On";
            else
                labelFirm.Text = "Off";


            //TPM
            //create a management scope object
            ManagementScope scope = new ManagementScope("\\\\.\\ROOT\\CIMV2\\Security\\MicrosoftTpm");

            //create object query
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_Tpm");

            //create object searcher
            ManagementObjectSearcher searcher =
                                    new ManagementObjectSearcher(scope, query);

            //get a collection of WMI objects
            ManagementObjectCollection queryCollection = searcher.Get();

            //enumerate the collection.
            foreach (ManagementObject m in queryCollection)
            {
                // access properties of the WMI object
                labelTpm.Text = m["SpecVersion"].ToString();

            }


            //GPU
            Search = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject Mobject in Search.Get())
            {
                //labelGpu.Text = Mobject["Name"].ToString();
                labelGpu.Text = Mobject["DriverVersion"].ToString();
            }

            Rectangle resolution = Screen.PrimaryScreen.Bounds;

            labelScreen.Text = resolution.Width.ToString() + " X " + resolution.Height.ToString();

        }
    }
}
