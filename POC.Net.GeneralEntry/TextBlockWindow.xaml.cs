// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 - 2013 Strategic Forge
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: TextBlockWindow.xaml.cs
// COMMENT - one line to give a brief idea of what this file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

namespace POC.Net.GeneralEntry {

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    using CodeEnv.Master.Common;
    using CodeEnv.Master.Common.LocalResources;


    /// <summary>
    /// Interaction logic for TextBlockWindow.xaml
    /// </summary>
    public partial class TextBlockWindow : Window {


        public TextBlockWindow() {
            InitializeComponent();

            SetupEventHandlers();
        }

        // method actually does nothing except initialize event handlers
        private void SetupEventHandlers() {
            // the lambda event handler w/anonomous method
            bottomButton.Click += (sender, eventArgs) =>
            {
                ClassDerivedFromBase derivedObj = new ClassDerivedFromBase();
                textArea.Text = derivedObj.ToString();
            };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            // a Windows.Loaded event has arrived           
        }

        public override string ToString() {
            return new ObjectAnalyzer().ToString(this);
        }


    }
}
