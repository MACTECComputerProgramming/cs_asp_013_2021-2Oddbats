using System;
using System.Collections.Generic;
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

namespace Mr_Wilsons_Subs_Challenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonOrder_Click(object sender, RoutedEventArgs e)
        {
            double total = 3.50;

            string subName = "Six Inch";

            //1. Size
            if (radioButtonFoot.IsChecked == true)
            {
                total = 5.00;
                subName = "Foot Long";
            }


            //2. Bread
            if (radioButtonWheat.IsChecked == true)
            {
                subName = subName + " On Wheat Bread With";
            }
            if (radioButtonItalian.IsChecked == true)
            {
                subName = subName + " On Italian Bread With";
            }
            if (radioButtonFlatBread.IsChecked == true)
            {
                subName = subName + " On Flat Bread With";
                total = total + 0.50;
            }

            //3. Meat
            if (checkBoxHam.IsChecked == true)
            {
                subName = subName + " Ham,";
            }
            if (checkBoxChicken.IsChecked == true)
            {
                subName = subName + " Chicken,";
            }
            if (checkBoxMeatball.IsChecked == true)
            {
                subName = subName + " Meatballs,";
                total = total + 1.00;
            }
            if (checkBoxSteak.IsChecked == true)
            {
                subName = subName + " Steak,";
                total = total + 1.50;
            }

            //4. Cheese
            if (checkBoxAmerican.IsChecked == true)
            {
                subName = subName + " American Cheese,";
                total = total + 0.25;
            }
            if (checkBoxSwiss.IsChecked == true)
            {
                subName = subName + " Swiss Cheese,";
                total = total + 0.30;
            }
            if (checkBoxPepper.IsChecked == true)
            {
                subName = subName + " PepperJack Cheese,";
                total = total + 0.75;
            }

            //5. Veg
            if (checkBoxCucumber.IsChecked == true)
            {
                subName = subName + " Cucumbers,";
            }
            if (checkBoxPepper.IsChecked == true)
            {
                subName = subName + " Green Peppers,";
                total = total + 0.25;
            }
            if (checkBoxLettuce.IsChecked == true)
            {
                subName = subName + " Lettuce,";
                total = total + 0.15;
            }
            if (checkBoxOnion.IsChecked == true)
            {
                subName = subName + " Red Onions,";
                total = total + 0.10;
            }
            if (checkBoxAll.IsChecked == true)
            {
                subName = subName + " And All Vegetables";
                total = total + 0.25;
            }

            //6. Special
            if (radioButtonFoot.IsChecked == true)
            {
                if (radioButtonWheat.IsChecked == true)
                {
                    if (checkBoxMeatball.IsChecked == true)
                    {
                        if (checkBoxAmerican.IsChecked == true)
                        {
                            total = total - 2.00;
                        }
                    }
                }
            }

            //5. Print
            labelResult.Content = subName + " $" + total;

        }
    }
}
