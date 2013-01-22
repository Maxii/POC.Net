// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 - 2013 Strategic Forge
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: BaseClass.cs
// COMMENT - one line to give a brief idea of what the file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

namespace POC.Net.GeneralEntry {

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CodeEnv.Master.Common;
    using CodeEnv.Master.Common.Resources;

    public class BaseClass {

        public string baseClassField = "Base Class Field";

        public BaseClass() { }

        public void BaseClassMethod() {

        }

        public override string ToString() {
            return new ObjectAnalyzer().ToString(this);
        }

    }
}

