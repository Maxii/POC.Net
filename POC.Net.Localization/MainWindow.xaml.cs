// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 Strategic Forge
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: MainWindow.xaml.cs
// COMMENT - one line to give a brief idea of what this file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

namespace POC.Net.Localization {

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        static string[] cultures = { "en-US", "fr-FR", "en-CA", "en-AU" };
        // en-AU falls back to the ResourceProject's en-US. either embedded in ResourceProject's Assembly or someplace else. The attribute setting in the MainAssy
        // says to fallback to 'en' in the embedded assembly! That means use no NeutralResourcesLanguageAttribute setting at all in the ResourceProject, but
        // use NeutralResourcesLanguageAttribute("en" or "en-US?") without the Satellite flag. The Main Project file should also include it's UICulture setting of "en-US". 
        //
        // Update: Upon further investigation, It appears now that the satellite assemblies are being made in the 
        // ResourceProject, and without the default Satellite assembly. This is expected. What is unexpected, is that the ResourceProject satellite assemblies are 
        // being copied to the Main Assembly as ResourceProject Satellite Assemblies, and that the default language (en-US) from the Resource Project is 
        // appearing as a Satellite Assembly in the Main Project labeled a MainProject Satellite Assembly. What is still unclear is 'which Assembly is the fallback
        // to the default using?' - the MainAssy with embedded resource, MainAssy's Satellite Assy or ResourceProject's Assembly as an embedded resource.
        // I judge the third as very unlikely.
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            //MyLabel.Content = POC.Net.Localization.ResourceProject.MyStrings.Hello;      // For testing Resources in Main Assembly
            MyLabel.Content = POC.Net.Localization.ResourceProject.UIMessages.Hello;
        }

        private void ChgCultureBtn_Click(object sender, RoutedEventArgs e) {
            Random rng = new Random();
            string cultureString = cultures[rng.Next(cultures.Length)];
            CultureInfo newCulture = new CultureInfo(cultureString);

            Thread.CurrentThread.CurrentCulture = newCulture;
            Thread.CurrentThread.CurrentUICulture = newCulture;

            Debug.WriteLine(String.Format("Current culture is now {0}", cultureString));

            //MyLabel.Content = POC.Net.Localization.ResourceProject.MyStrings.Hello;      // For testing Resources in Main Assembly
            MyLabel.Content = POC.Net.Localization.ResourceProject.UIMessages.Hello;

        }



    }
}
