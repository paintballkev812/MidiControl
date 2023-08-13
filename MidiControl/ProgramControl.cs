using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiControl
{
    public class ProgramControl : IExternalControl
    {

        public void LaunchProgram(string File, string Arg, Boolean Hidden)
        {
            Process p = new Process();
            p.StartInfo.FileName = File;
            p.StartInfo.Arguments = Arg;
            if (Hidden) 
            { 
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            }
            p.Start();

        }

        public bool IsEnabled()
        {
            return true;
        }
    }
}
