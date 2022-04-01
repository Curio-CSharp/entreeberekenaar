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
        private int aantalVolwassen = 0;
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
            int aantalVolwassenen;
            if (int.TryParse(tbAantalVolwassenen.Text, out aantalVolwassenen) == false)
            {
                tbBedrag.Text = "(aantal volwassenen is ongeldig)";
                return;
            }


            //	Doe hier ook de andere checks of de invoer juist is


            double eindBedrag = 0;
            
            // Hier komt de berekening van het eindbedrag

            tbBedrag.Text = eindBedrag.ToString();

        }

        private void tbAantalVolwassenen_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.aantalVolwassen = getIntegerFromInput(sender);
        }

        private void tbAantalKinderen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("Luxe");
            comboBox.Items.Add("Normaal");


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var aantalKinderen = getIntegerFromText(this.tbAantalKinderen.Text);
            var aantalVolwassen = getIntegerFromText(this.tbAantalVolwassenen.Text);
            int parkeerBedrag = 0;
            if (tbParkeerBedrag.IsChecked == true)
            {
                parkeerBedrag = (int)5.00;
            }

            var eindBedrag = (aantalKinderen * 7.50) + (aantalVolwassen * 12.50) + (parkeerBedrag);
            this.tbBedrag.Text = eindBedrag.ToString();
        }

  

        private String getStringFromInput(object sender)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
               return textBox.Text;
            }
            return null;
        }
        private int getIntegerFromInput(object sender)
        {
            try
            {
                int result = Int32.Parse(getStringFromInput(sender));
                return result;
            }  catch (FormatException)
            {
                return 0;
            }
        }
        private int getIntegerFromText(String s)
        {
            try
            {
                int result = Int32.Parse(s);
                return result;
            }
            catch (FormatException)
            {
                return 0;
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var parkeerKaart = true;
        }
    }
}
