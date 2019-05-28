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

namespace Calculator
{
    /// <summary>
    /// Главное окно 
    /// </summary>
    public partial class MainWindow : Window
    {
        //Инициализация копонентов
        public MainWindow()
        {
            InitializeComponent();
        }

        //Выход из прогаммы
        private void ExitInProgram(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void EditebleContent(object sender, TextChangedEventArgs e)
        {
            switch (((TextBox)sender).Text.ToArray()[((TextBox)sender).Text.Length-1])
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '(':
                    ((TextBox)sender).Text += "\n";

                    break;

                default:
                    break;
            }
        }

        private void EnterButton(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
