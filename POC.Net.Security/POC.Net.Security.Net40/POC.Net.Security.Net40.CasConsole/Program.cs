
namespace POC.Net.Security.Net40.CasConsole {

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using System.Security.Policy;
    using System.Text;
    using POC.Net.Security.Net40.CasAssemblyInfo;

    class Program {

        static void Main(string[] args) {
            //get the assembly zone evidence
            Zone z = Assembly.GetExecutingAssembly().Evidence.GetHostEvidence<Zone>();
            Debug.WriteLine("Zone Evidence: " + z.SecurityZone.ToString() + "\n");
            Debug.WriteLine(new AssemblyInfo().GetCasSecurityAttributes());
        }
    }
}
