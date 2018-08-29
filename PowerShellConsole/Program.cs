using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            PSListenerConsoleSample scc = new PSListenerConsoleSample();
            ConsoleManager.Show();
            scc.RuningPowerShell();
        }
    }
}
