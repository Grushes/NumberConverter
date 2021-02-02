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

namespace WPF_Examples
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            

        }

        private void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(DecTextBox.Text != "Введите число")
            {
                ResultDecToHex.Text = Converter.DecToHex(DecTextBox.Text);
            }
            if(HexTextBox.Text != "Введите число")
            {
                ResultHexToDec.Text = Converter.HexToDec(HexTextBox.Text).ToString();
            }

        }


    }
    
}
