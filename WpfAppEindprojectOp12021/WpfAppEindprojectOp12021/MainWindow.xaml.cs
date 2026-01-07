using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace WpfAppEindprojectOp12021
{
    /// <summary>
    /// Interactielogica voor MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //variabelen
        int _count = 0; //telt het aantal keren dat een knop is ingedrukt
        int totaal = 0; //totaal variabele
        private bool btn1 = false; //status van knop 1
        private bool btn2 = false; //status van knop 2
        private bool btn3 = false; //status van knop 3
        private bool btn4 = false; //status van knop 4

        public MainWindow()
        {
            InitializeComponent(); //initialiseert de componenten van het venster
        }

        private void btOne_Click(object sender, RoutedEventArgs e)
        {
            if (btOne.Background == Brushes.DarkGray) //controleert knop als niet ingedrukt blijft donkergrijs
            {
                btOne.Background = Brushes.LightGray; //als de knop is ingedrukt, maakt de knop lichtgrijs
                btOne.Content = "Button 1 is pressed"; //als de knop is ingedrukt, verandert de tekstinhoud in de opgegeven tekenreeks
            }
            else
            {
                btOne.Background = Brushes.DarkGray; //als de knop opnieuw wordt ingedrukt, wordt deze weer donkergrijs
                btOne.Content = "Button 1"; //verandert de tekstinhoud in de opgegeven tekenreeks
            }
            DoMyThing(1); //roept de DoMyThing methode aan met parameter 1
        }

        private void btTwo_Click(object sender, RoutedEventArgs e)
        {
            if (btTwo.Background == Brushes.DarkGray) //controleert knop als niet ingedrukt blijft donkergrijs
            {
                btTwo.Background = Brushes.LightGray; //als de knop is ingedrukt, maakt de knop lichtgrijs
                btTwo.Content = "Button 2 is pressed"; //als de knop is ingedrukt, verandert de tekstinhoud in de opgegeven tekenreeks
            }
            else
            {
                btTwo.Background = Brushes.DarkGray; //als de knop opnieuw wordt ingedrukt, wordt deze weer donkergrijs
                btTwo.Content = "Button 2"; //verandert de tekstinhoud in de opgegeven tekenreeks
            }
            DoMyThing(2); //roept de DoMyThing methode aan met parameter 2
        }

        private void btThree_Click(object sender, RoutedEventArgs e)
        {
            if (btThree.Background == Brushes.DarkGray) //controleert knop als niet ingedrukt blijft donkergrijs
            {
                btThree.Background = Brushes.LightGray; //als de knop is ingedrukt, maakt de knop lichtgrijs
                btThree.Content = "Button 3 is pressed"; //als de knop is ingedrukt, verandert de tekstinhoud in de opgegeven tekenreeks
            }
            else
            {
                btThree.Background = Brushes.DarkGray; //als de knop opnieuw wordt ingedrukt, wordt deze weer donkergrijs
                btThree.Content = "Button 3"; //verandert de tekstinhoud in de opgegeven tekenreeks
            }
            DoMyThing(3); //roept de DoMyThing methode aan met parameter 3
        }

        private void btFour_Click(object sender, RoutedEventArgs e)
        {
            if (btFour.Background == Brushes.DarkGray) //controleert knop als niet ingedrukt blijft donkergrijs
            {
                btFour.Background = Brushes.LightGray; //als de knop is ingedrukt, maakt de knop lichtgrijs
                btFour.Content = "Button 4 is pressed"; //als de knop is ingedrukt, verandert de tekstinhoud in de opgegeven tekenreeks
            }
            else
            {
                btFour.Background = Brushes.DarkGray; //als de knop opnieuw wordt ingedrukt, wordt deze weer donkergrijs
                btFour.Content = "Button 4"; //verandert de tekstinhoud in de opgegeven tekenreeks
            }
            DoMyThing(4); //roept de DoMyThing methode aan met parameter 4
        }

        private void DoMyThing(int mousenum)
        {
            switch (mousenum)
            {
                case 1:
                    btn1 = !btn1; //knop is niet de valse knop vals dus het is waar
                    break; //stopt de huidige case
                case 2:
                    btn2 = !btn2; //knop is niet de valse knop vals dus het is waar
                    break; //stopt de huidige case
                case 3:
                    btn3 = !btn3; //knop is niet de valse knop vals dus het is waar
                    break; //stopt de huidige case
                case 4:
                    btn4 = !btn4; //knop is niet de valse knop vals dus het is waar
                    break; //stopt de huidige case
                default: //doe wat standaard is of niets
                    break; //stopt de huidige case
            }

            //verklaring dat bepaalde specifieke knoppen aan moeten staan om te werken
            if (btn1 == false && btn2 == false && btn3 == false && btn4 == false)
            {
                gridColor.Background = Brushes.White; //maakt achtergrond wit
            }
            else if (btn1 == true && btn2 == false && btn3 == false && btn4 == false)
            {
                gridColor.Background = Brushes.Red; //maakt achtergrond rood
            }
            else if (btn1 == true && btn2 == true && btn3 == true && btn4 == false)
            {
                gridColor.Background = Brushes.Green; //maakt achtergrond groen
            }
            else if (btn1 == true && btn2 == true && btn3 == false)
            {
                gridColor.Background = Brushes.Yellow; //maakt achtergrond geel
            }
            else if (btn1 == false && btn2 == false && btn3 == true && btn4 == true)
            {
                gridColor.Background = Brushes.Blue; //maakt achtergrond blauw
            }
            else if (btn1 == true && btn2 == true && btn3 == true && btn4 == true)
            {
                gridColor.Background = Brushes.Black; //maakt achtergrond zwart
            }
            else
            {
                gridColor.Background = Brushes.Purple; //maakt achtergrond paars
            }
        }

        private void GoOne_click(object sender, RoutedEventArgs e)
        {
            //variabelen
            int macht = int.Parse(tbPower.Text); //neemt de invoerwaarde van de string in int en zal worden gebruikt om te bepalen hoe vaak de for loop wordt gemaakt
            int begin = int.Parse(begingetal.Text); //neemt de tekenreeksinvoerwaarde over in int en is de basiswaarde die voortdurend wordt vermenigvuldigd
            int temp = begin; //is een tijdelijke waarde om het proces van de vermenigvuldiging weer te geven
            string result = null; //stringresultaat dat aan het einde wordt weergegeven

            for (int i = 1; i <= macht; i++) //een loop gebaseerd op hoe vaak het grondtal moet worden vermenigvuldigd
            {
                if (result == null) //controleert of het resultaat null is                
                {
                    result = begin.ToString(); //stelt het grondtal in aan het begin van de resultaatreeks
                }
                else
                {
                    temp *= begin; //vermenigvuldigt het tijdelijke getal met het grondtal
                    result += ", " + temp.ToString(); //bouwt de eindresultaatreeks
                }
            }
            tbReeks.Text = result; //geeft het resultaat weer
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _count++; //blijf 1 toevoegen aan de telling
            tbCounter.Text = _count.ToString(); //telling omgezet naar string om weer te geven in het tekstvak

            if (_count == 4) //looping statement tot telling gelijk is aan 4
            {
                _count = -1; //telling begint bij -1
            }
        }

        private void GoTwo_Click_1(object sender, RoutedEventArgs e)
        {
            //variabelen
            string result = tbAnimal.Text; //neemt de invoerwaarde van het tekstvak tbAnimal
            ComboBoxItem cmbTemp; //tijdelijke variabele voor combobox items
            bool found = false; //boolean om te controleren of het dier is gevonden

            for (int i = 0; i < cmbAnimals.Items.Count; i++) //telling toevoegen van de dieren combobox lijst
            {
                cmbTemp = (ComboBoxItem)cmbAnimals.Items[i]; //de items in de combobox een variabele geven

                if (result.ToLower() == cmbTemp.Content.ToString().ToLower()) //controleren of het resultaat gelijk is aan de inhoud van de combobox, converteert de inhoud van de combobox ook naar een tekenreeks in kleine letters
                {
                    MessageBox.Show("Het te zoeken dier is gevonden, het is het nummer " + i); //messagebox die verschijnt met opgegeven tekenreeksinhoud + welk nummer het is
                    found = true; //boolean controleren of het waar is
                    break; //stopt de loop als de voorwaarden zijn vervuld
                }
            }
            if (!found) //if statement voor wanneer het dier niet wordt gevonden in de combobox
            {
                MessageBox.Show("Helaas, het dier dat jij zoekt is niet gevonden"); //messagebox die verschijnt met opgegeven tekenreeksinhoud
            }
        }
    }
}