using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessExecuteWithInput
{

    public class ExecuteLiquibase
    {
        ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo(@"C:\Users\venkat\Documents\Visual Studio 2017\Projects\LiquibaseConsoleApp\LiquibaseConsoleApp\bin\Release\LiquibaseConsoleApp.exe");
        Process p = new Process();
        TextWriter _standardInput;
        public TextWriter StandardInput
        {
            get => _standardInput;
            set => _standardInput = value;
        }
        TextReader tr;
        public void StartProcess()
        {
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardInput = true;
            processInfo.RedirectStandardOutput = true;
          
            p.StartInfo = processInfo;
            p.Start();
            StandardInput = p.StandardInput;
            // tr = p.StandardOutput;
            p.OutputDataReceived += P_OutputDataReceived;
            p.ErrorDataReceived += P_ErrorDataReceived; 
            p.
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            p.WaitForExit();
        }

        private  void P_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            string error = e.Data;
            Console.WriteLine(error);
        }

        private  void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            string data = e.Data;
            Console.WriteLine(data);
            if(data.Trim().ToLower().Contains("Select your Environment".ToLower()))
            {
                string userinput = Console.ReadLine();
                this.StandardInput.WriteLine(userinput);
            }
            if (data.Trim().ToLower().Contains("Liquibase Successfully Updated".ToLower()))
            {
                string userinput = Console.ReadKey().KeyChar.ToString();
                this.StandardInput.WriteLine(userinput);
            }

            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            new ExecuteLiquibase().StartProcess();
        }

    }
}
