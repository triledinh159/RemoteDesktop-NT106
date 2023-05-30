using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace RemoteClient
{
    public static class ScheduleTask
    {
        public static bool AddNewTask(string TaskName, string Description)
        {
            string Author = Environment.MachineName + "\\" + Environment.UserName;
            string FileName = Application.ExecutablePath;
            return AddNewTask(TaskName, FileName, Description, Author);
        }
        public static bool AddNewTask(string TaskName, string FileName, string Description, string Author)
        {
            try
            {
                string Au = Environment.MachineName + "\\" + Environment.UserName;
                string TheDate = DateTime.Now.Year + "-";
                if (DateTime.Now.Month > 9) TheDate += DateTime.Now.Month + "-"; else TheDate += "0" + DateTime.Now.Month + "-";
                if (DateTime.Now.Day > 9) TheDate += DateTime.Now.Month; else TheDate += "0" + DateTime.Now.Day;
                string XML = GetTemplate().Replace("#FILENAME#", FileName).Replace("#DESCRIPTION#", Description).Replace("#AUTHOR#", Author).Replace("#DATE#", TheDate);
                string XMLFileName = Application.StartupPath + "Task.xml";
                File.WriteAllText(XMLFileName, XML);
                string Result = ExecuteCommandAsAdmin(@"schtasks.exe /Delete /tn '" + TaskName + "' /F");
                Result = ExecuteCommandAsAdmin(@"schtasks.exe /Create /XML '" + XMLFileName + "' /tn '" + TaskName + "'");
                return Result.StartsWith("SUCCESS:");
            }
            catch { ; }
            return false;
        }

        public static string ExecuteCommandAsAdmin(string command)
        {
            ProcessStartInfo psinfo = new ProcessStartInfo();
            psinfo.FileName = "powershell.exe";
            psinfo.Arguments = command;
            psinfo.RedirectStandardError = true;
            psinfo.RedirectStandardOutput = true;
            psinfo.UseShellExecute = false;

            using (Process proc = new Process())
            {
                proc.StartInfo = psinfo;
                proc.Start();

                string output = proc.StandardOutput.ReadToEnd();

                if (string.IsNullOrEmpty(output))
                    output = proc.StandardError.ReadToEnd();

                return output;
            }
        }

        private static string GetTemplate()
        {

            string XML = "<?xml version=\"1.0\" encoding=\"UTF-16\"?>" + Environment.NewLine;
            XML += "<Task version=\"1.2\" xmlns=\"http://schemas.microsoft.com/windows/2004/02/mit/task\">" + Environment.NewLine;
            XML += "<RegistrationInfo>" + Environment.NewLine;
            XML += "<Date>#DATE#T11:37:54.5063431</Date>" + Environment.NewLine;
            XML += "<Author>#AUTHOR#</Author>" + Environment.NewLine;
            XML += "<Description>#DESCRIPTION#</Description>" + Environment.NewLine;
            XML += "</RegistrationInfo>" + Environment.NewLine;
            XML += "<Triggers>" + Environment.NewLine;
            XML += "<LogonTrigger>" + Environment.NewLine;
            XML += "<Enabled>true</Enabled>" + Environment.NewLine;
            XML += "</LogonTrigger>" + Environment.NewLine;
            XML += "</Triggers>" + Environment.NewLine;
            XML += "<Principals>" + Environment.NewLine;
            XML += "<Principal id=\"Author\">" + Environment.NewLine;
            XML += "<UserId>#AUTHOR#</UserId>" + Environment.NewLine;
            XML += "<LogonType>InteractiveToken</LogonType>" + Environment.NewLine;
            XML += "<RunLevel>HighestAvailable</RunLevel>" + Environment.NewLine;
            XML += "</Principal>" + Environment.NewLine;
            XML += "</Principals>" + Environment.NewLine;
            XML += "<Settings>" + Environment.NewLine;
            XML += "<MultipleInstancesPolicy>IgnoreNew</MultipleInstancesPolicy>" + Environment.NewLine;
            XML += "<DisallowStartIfOnBatteries>false</DisallowStartIfOnBatteries>" + Environment.NewLine;
            XML += "<StopIfGoingOnBatteries>true</StopIfGoingOnBatteries>" + Environment.NewLine;
            XML += "<AllowHardTerminate>true</AllowHardTerminate>" + Environment.NewLine;
            XML += "<StartWhenAvailable>false</StartWhenAvailable>" + Environment.NewLine;
            XML += "<RunOnlyIfNetworkAvailable>false</RunOnlyIfNetworkAvailable>" + Environment.NewLine;
            XML += "<IdleSettings>" + Environment.NewLine;
            XML += "<StopOnIdleEnd>true</StopOnIdleEnd>" + Environment.NewLine;
            XML += "<RestartOnIdle>false</RestartOnIdle>" + Environment.NewLine;
            XML += "</IdleSettings>" + Environment.NewLine;
            XML += "<AllowStartOnDemand>true</AllowStartOnDemand>" + Environment.NewLine;
            XML += "<Enabled>true</Enabled>" + Environment.NewLine;
            XML += "<Hidden>false</Hidden>" + Environment.NewLine;
            XML += "<RunOnlyIfIdle>false</RunOnlyIfIdle>" + Environment.NewLine;
            XML += "<WakeToRun>false</WakeToRun>" + Environment.NewLine;
            XML += "<ExecutionTimeLimit>PT0S</ExecutionTimeLimit>" + Environment.NewLine;
            XML += "<Priority>7</Priority>" + Environment.NewLine;
            XML += "</Settings>" + Environment.NewLine;
            XML += "<Actions Context=\"Author\">" + Environment.NewLine;
            XML += "<Exec>" + Environment.NewLine;
            XML += "<Command>#FILENAME#</Command>" + Environment.NewLine;
            XML += "</Exec>" + Environment.NewLine;
            XML += "</Actions>" + Environment.NewLine;
            XML += "</Task>" + Environment.NewLine;
            return XML;
        }
    }
}
