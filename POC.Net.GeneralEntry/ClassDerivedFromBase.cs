// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 - 2013 Strategic Forge
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: ClassDerivedFromBase.cs
// COMMENT - one line to give a brief idea of what the file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

namespace POC.Net.GeneralEntry {

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CodeEnv.Master.Common;
    using CodeEnv.Master.Common.Resources;

    public class ClassDerivedFromBase : BaseClass {

        public string classDerivedFromBaseField = "Derived Class Field";

        public ClassDerivedFromBase() { }

        public void ClassDerivedFromBaseMethod() {

        }

        public override string ToString() {
            return new ObjectAnalyzer().ToString(this);
        }

    }
}

