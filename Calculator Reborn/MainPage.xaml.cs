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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculator_Reborn
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Calculator_Operation(object sender, RoutedEventArgs e)
        {
            switch((sender as Button).Content)
            {
                case "1":
                    calculator_view.Text += "1";
                    break;
                case "2":
                    calculator_view.Text += "2";
                    break;
                case "3":
                    calculator_view.Text += "3";
                    break;
                case "4":
                    calculator_view.Text += "4";
                    break;
                case "5":
                    calculator_view.Text += "5";
                    break;
                case "6":
                    calculator_view.Text += "6";
                    break;
                case "7":
                    calculator_view.Text += "7";
                    break;
                case "8":
                    calculator_view.Text += "8";
                    break;
                case "9":
                    calculator_view.Text += "9";
                    break;
            }
        }
    }
}
