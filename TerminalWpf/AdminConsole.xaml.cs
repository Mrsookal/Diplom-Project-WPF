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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using MySql.Data;



namespace TerminalWpf
{
    /// <summary>
    /// Логика взаимодействия для AdminConsole.xaml
    /// </summary>
    public partial class AdminConsole : Window
    {
        public AdminConsole()
        {
            int part1;
            int part2;
            InitializeComponent();
            string str2 = $"select count(1) from mail_claim;";
            MySqlConnection conn = Dbu.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(str2, conn);
            conn.Open();
            part1 = Convert.ToInt32(cmDB.ExecuteScalar());
            conn.Close();

            string str1 = $"select count(1) from mail_comment;";
            MySqlCommand cmDB2 = new MySqlCommand(str1, conn);
            conn.Open();
            part2 = Convert.ToInt32(cmDB2.ExecuteScalar());
            conn.Close();
            
            lablelalltime.Content =$"Обращений к термиалу за все время {part1+part2}";
            lablelallclaim.Content = $"Колличество отзывов {part2}";
            lablelallcomment.Content = $"Колличество жалоб {part1}";
        }

      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // day
        {
  
            var mail = CodeloMail.CreateMail($" От Терминал", "juliatestapplication@gmail.com", $"juliatestapplication@gmail.com", $"Отчетность за {DateTime.Now.ToLongDateString()}", "За сегодняшний день было получено 2 отзыва. " + Environment.NewLine + "Из которых:"+Environment.NewLine+"1 негативный(ых) и 1 позитивный(ых)"+Environment.NewLine+Environment.NewLine + "1  Негативный(ых) отзыв(ов) с оценкой 5" +Environment.NewLine+"1 Позитивный(ых) с оценкой 5" ); //cюда запрос с скл
            CodeloMail.SendMail("smtp.gmail.com", 587, "kolomeitseva2002@gmail.com", "kjujwsnmiditlejy", mail);
            MessageBox.Show("Отчетность отправлена");
        }

        private void closebut_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            var mail = CodeloMail.CreateMail($" От Терминал", "juliatestapplication@gmail.com", $"juliatestapplication@gmail.com", $"Отчетность за {DateTime.Now.ToLongDateString()}", "За сегодняшний день было получено 2 отзыва. " + Environment.NewLine + "Из которых:" + Environment.NewLine + "4 негативный(ых) и 7 позитивный(ых)" + Environment.NewLine + Environment.NewLine + "2  Негативный(ых) отзыв(ов) с оценкой 5" + Environment.NewLine + "1  Негативный(ых) отзыв(ов) с оценкой 3" + Environment.NewLine + "1  Негативный(ых) отзыв(ов) с оценкой 1" + Environment.NewLine + "4 Позитивный(ых) с оценкой 5" + Environment.NewLine + "1 Позитивный(ых) с оценкой 5" + Environment.NewLine + "3 Позитивный(ых) с оценкой 4"); //cюда запрос с скл
            CodeloMail.SendMail("smtp.gmail.com", 587, "kolomeitseva2002@gmail.com", "kjujwsnmiditlejy", mail);
            MessageBox.Show("Отчетность отправлена");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
