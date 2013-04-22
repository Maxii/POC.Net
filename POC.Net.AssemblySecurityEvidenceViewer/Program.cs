// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 - 2013 Strategic Forge
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: Program.cs
// Opens Command window that allows reading of security attributes from an assembly.
// Enter the full path to the assembly when prompted.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

namespace POC.Net.AssemblySecurityEvidenceViewer {

    using System;
    using System.Collections;
    using System.Linq;
    using System.Text;
    using System.Reflection;
    using System.Security.Policy;

    class Program {

        static void Main(string[] args) {

            bool isUserDone = false;
            string userOption = "";
            Assembly asm = null;

            Console.WriteLine("***** Evidence Viewer *****\n");
            do {
                Console.Write("L (load assembly) or Q (quit): ");
                userOption = Console.ReadLine();
                switch (userOption.ToLower()) {
                    case "l":
                        asm = LoadAsm();
                        if (asm != null) {
                            DisplayAsmEvidence(asm);
                        }
                        break;
                    case "q":
                        isUserDone = true;
                        break;
                    default:
                        Console.WriteLine("I have no idea what you want!");
                        break;

                }

            } while (!isUserDone);
        }

        private static Assembly LoadAsm() {
            Console.Write("Enter path to assembly: ");
            try {
                return Assembly.LoadFrom(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Load error ...");
                return null;
            }
        }

        private static void DisplayAsmEvidence(Assembly asm) {
            Evidence e = asm.Evidence;
            IEnumerator itfEnum = e.GetHostEnumerator();
            while (itfEnum.MoveNext()) {
                Console.WriteLine(" **** Press Enter to continue ****");
                Console.ReadLine();
                Console.WriteLine(itfEnum.Current);
            }
        }
    }
}
