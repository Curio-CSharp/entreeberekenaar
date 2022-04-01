using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace EntreeBerekenaar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int aantalKinderen;
            if (int.TryParse(tbAantalKinderen.Text, out aantalKinderen) == false)
            {
                tbBedrag.Text = "(aantal kinderen is ongeldig)";
                return;
            }


           	//	Doe hier ook de andere checks of de invoer juist is
            
            
            double eindBedrag = 0;
            
            // Hier komt de berekening van het eindbedrag

            tbBedrag.Text = eindBedrag.ToString();

        }
    }
}
