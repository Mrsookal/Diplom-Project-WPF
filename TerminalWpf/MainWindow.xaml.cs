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

namespace TerminalWpf
{
    // https://www.youtube.com/watch?v=lUvO6uf2pPw&list=PL0lO_mIqDDFVI0xwaYbm7h9ewYu5hftfA&index=8 смотри
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
           // string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            InitializeComponent();
           // MessageBox.Show(Convert.ToString(""));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //команда на отзыв
        {
            Zhaloba zhaloba = new Zhaloba();
            zhaloba.Show();
            this.Hide();
            Close();
            
            Global.chouse = 2;
        }

       
        private void Button_Click_1(object sender, RoutedEventArgs e) //команда на жалобу
        {
            Zhaloba zhaloba = new Zhaloba();
            zhaloba.Show();
            this.Hide();
            Close();
            Global.chouse = 1;
        }
    }
}
