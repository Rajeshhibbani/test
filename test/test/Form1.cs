using System;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using System.Runtime.InteropServices;
namespace test
{
    public partial class Form1 : Form
    {
        //for capturing the current process id
        private string current_process_pid = null;
        //to check the process or new instance of the application is triggered by button or other source
        public static string trigger_by_button = ConfigurationManager.AppSettings["Triggerbutton"];
        //Aplication name
        string s_Process_Name = "test";
       // for setting the main application to ForegroundWindow
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd,int nCmdShow);
        const int SW_SHOW = 5;
        public Form1()
        {
            //to check the process or new instance of the application is triggered by button or other source
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            Process process = Process.GetCurrentProcess();
            current_process_pid = process.Id.ToString();
            // if the instance is triggered by button 
            if (trigger_by_button == "true")
            {
                InitializeComponent();
                config.AppSettings.Settings["Triggerbutton"].Value = "false";
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("appSettings");                
                config = null;
            }
            //if triggered by other means fileexplorer or cmd prompt
            else if (trigger_by_button == "false")
            {
                Process[] processes = Process.GetProcessesByName(s_Process_Name);
                if (processes.Length > 1)
                {// to bring the main windows form process to foreground
                            ShowWindow(processes[0].MainWindowHandle, SW_SHOW);
                            SetForegroundWindow(processes[0].MainWindowHandle);                            
                     //To kill this process   
                    process.Kill();
                }
                else
                {
                    InitializeComponent();
                }
            }
            else
            {
                InitializeComponent();
            }
        }
        //using the custom button and not the windows close button
        private void Close_button_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;            
        }
        // to terminate the current application
        private void Terminate_current_instance_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // to trigger the new instance of application
        private void New_instance_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["Triggerbutton"].Value = "true";
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("appSettings");
            Process.Start(Application.ExecutablePath);

            config = null;            
        }
        // to terminate all the process 
        private void Terminate_all_process_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName(s_Process_Name);
            if (processes.Length > 0)
            {
                foreach (var process in processes)
                {
                    Process process_id = Process.GetProcessById(process.Id);
                    if (current_process_pid != process.Id.ToString())
                        process_id.Kill();
                }
            }            
            Application.Exit();
        }
        //for drag and drop
        bool mousedown ;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }
    }
}
