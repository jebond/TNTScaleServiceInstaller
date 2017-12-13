using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Configuration.Install;
using Microsoft.Win32.TaskScheduler;
using System.ServiceProcess;

namespace TNTScaleServiceInstaller
{
    public partial class Form1 : Form
    {
        string outputpath;
        string serverpath;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog SelectOutPutDirectory = new FolderBrowserDialog();
            SelectOutPutDirectory.ShowDialog();
            string path = SelectOutPutDirectory.SelectedPath.ToString();
            label1.Text = path;
            outputpath = path;
            serverpath = txtpath.Text;
            txtdebug.Visible = true;
            txtlog.Visible = true;
            txtdebug.Visible = true;
            pathlabel.Visible = true;
            pathlog.Visible = true;
            txtpath.Visible = true;
            debuglabel.Visible = true;
            btnsaveconfig.Visible = true;
            lblsec.Visible = true;
            txtsec.Visible = true;
            checkBox1.Visible = true;
        }

        private void btnsaveconfig_Click(object sender, EventArgs e)
        {
            var zipservice = Properties.Resources.TNTService;
            string publicpath = @"C:\users\public\documents\TNTService.zip";
            try
            {
                File.WriteAllBytes(publicpath, zipservice);
                ZipFile.ExtractToDirectory(publicpath, outputpath);
                string ConfigFile = Properties.Resources.TNTScaleService_exe;

                StringBuilder configbaby = new StringBuilder();
                configbaby.Append(@"<?xml version=""1.0"" encoding=""utf-8""?>" + Environment.NewLine + "<configuration>" + Environment.NewLine + "<startup>" + Environment.NewLine + @"<supportedRuntime version = ""v4.0"" sku = "".NETFramework,Version=v4.6.1"" />" + Environment.NewLine + "</startup>" + Environment.NewLine + "<appSettings>" + Environment.NewLine + "");
                configbaby.Append(@"<add key=""WebServiceUrl"" value=""" + txtpath.Text + @"/addweight/""/>" + Environment.NewLine);
                configbaby.Append(@"<add key = ""LogFileOutput"" value = """ + txtlog.Text + @"scale.log""" + "/>" + Environment.NewLine);
                configbaby.Append(@"<add key = ""LogFileOutput"" value = """ + txtlog.Text + @"http.log""" + "/>" + Environment.NewLine);
                configbaby.Append(@"<add key = ""DebugMode"" value = """ + txtdebug.Text + @"""/>" + Environment.NewLine);
                configbaby.Append(@"<add key=""ScaleCheckFrequencyMilliseconds"" value=""" + txtsec.Text +@""" />" + Environment.NewLine);
                configbaby.Append(@"<add key=""ClientSettingsProvider.ServiceUri"" value="""" />" + Environment.NewLine);
                configbaby.Append(@"</appSettings>" + Environment.NewLine + "<system.web>" + Environment.NewLine + @"<membership defaultProvider=""ClientAuthenticationMembershipProvider"">" + Environment.NewLine + "<providers>" + Environment.NewLine + @"<add name = ""ClientAuthenticationMembershipProvider"" type = ""System.Web.ClientServices.Providers.ClientFormsAuthenticationMembershipProvider, System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" serviceUri = """"/>" + Environment.NewLine + "</providers>" + Environment.NewLine + "</membership>" + Environment.NewLine + @"<roleManager defaultProvider = ""ClientRoleProvider"" enabled = ""true"">" + Environment.NewLine + "<providers>" + Environment.NewLine + @"<add name = ""ClientRoleProvider"" type = ""System.Web.ClientServices.Providers.ClientRoleProvider, System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" serviceUri = """" cacheTimeout = ""86400""/>" + Environment.NewLine + "</providers>" + Environment.NewLine + "</roleManager>" + Environment.NewLine + "</system.web>" + Environment.NewLine + "</configuration>");
                File.WriteAllText(outputpath + "\\TNTScaleService.exe.config", configbaby.ToString());
                lblstatus.Text = "Files Extracted to selected path and config xml updated";
                lblstatus.Visible = Visible;
                btninstall.Visible = Visible;
            }
            catch (Exception ex) {
                lblstatus.Text = "Unable to create files, do they exist already?";
                lblstatus.Visible = Visible;
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btninstall_Click(object sender, EventArgs e)
        {
            InstallService(outputpath + "\\TNTScaleService.exe");
            CreateTask(outputpath);
        }

        public static void InstallService(string ExeFilename)
        {
            try
            {
                System.Configuration.Install.AssemblyInstaller Installer = new AssemblyInstaller(ExeFilename, null);
                Installer.UseNewContext = true;
                Installer.Install(null);
                Installer.Commit(null);
                MessageBox.Show("Service Installed Successfully");
                StartService("TnTScaleService");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void StartService(string ServiceName)
        {
            ServiceController service = new ServiceController(ServiceName);
            try
            {
                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running);
                MessageBox.Show("Service Started");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CreateTask(string directory)
        {
            try
            {
                TaskService ts = new TaskService();

                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Restarts TNT Scale Service";

                // Add a trigger that, starting now, will fire every day
                // and repeat every 1 minute.
                var dt = new DailyTrigger();
                dt.StartBoundary = DateTime.Now;
                dt.Repetition.Interval = TimeSpan.FromSeconds(10800);
                td.Triggers.Add(dt);
                td.Principal.RunLevel = TaskRunLevel.Highest;
                td.Settings.AllowDemandStart = true;
                // Create an action that will launch Notepad whenever the trigger fires
                td.Actions.Add(new ExecAction(directory + "\\schedule.bat", "c:\\users\\public\\documents\\test.log", null));
                // Register the task in the root folder
                ts.RootFolder.RegisterTaskDefinition("TNTScaleServiceRestartTask", td);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                lblapp.Visible = true;
                lblscale.Visible = true;
                lblprinter.Visible = true;
                txtapp.Visible = true;
                txtscale.Visible = true;
                txtprinter.Visible = true;
                btnhosts.Visible = true;
            }
            else
            {
                lblapp.Visible = false;
                lblscale.Visible = false;
                lblprinter.Visible = false;
                txtapp.Visible = false;
                txtscale.Visible = false;
                txtprinter.Visible = false;
                btnhosts.Visible = false;
            }
        }

        private void btnhosts_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
                {
                    w.WriteLine(txtapp.Text + " apps.trollandtoad.com");
                    w.WriteLine(txtscale.Text + " scale.trollandtoad.com");
                    w.WriteLine(txtprinter.Text + " printer.trollandtoad.com");
                    w.WriteLine(Environment.NewLine);
                    w.WriteLine(Environment.NewLine);

                }
                lblstatus.Text = "Host File Updated";
                lblstatus.Visible = Visible;
            }
            catch(Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
