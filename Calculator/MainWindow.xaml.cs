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
            
        }

        private void EnterButton(object sender, RoutedEventArgs e)
        {
            var button = ((Button)sender);
            switch (button.Content)
            {
                case "+":
                case "-":
                case "X":
                case "/":
                case "(":
                    Content.Text += $"\n{button.Content}\n";
                    break;

                default:
                    Content.Text += $"{button.Content}";

                    break;
            }
        }
    }
}
