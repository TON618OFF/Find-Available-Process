using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAvailableProcess
{
    public class FindProcessOrigin
    {
        public List<string> ListOfProcesses()
        {
            List<string> processNames = new List<string>();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                processNames.Add(process.ProcessName);
            }
            return processNames;
        }
    }
}
