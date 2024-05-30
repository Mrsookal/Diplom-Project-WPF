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
using System.Net;
using System.Net.Mail;
using System.Windows.Threading;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace TerminalWpf
{
    /// <summary>
    /// Логика взаимодействия для Final.xaml
    /// </summary>
    public partial class Final : Window
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        DispatcherTimer dispatcherTimer2 = new DispatcherTimer();
        
        int time;
        public Final()
        {
            InitializeComponent();
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
           
            dispatcherTimer.Interval = new TimeSpan(0, 0, 16);
            dispatcherTimer.Start();

            dispatcherTimer2.Tick += new EventHandler(dispatcherTimer_Tick2);
            dispatcherTimer2.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer2.Start();
            time = 16;



        }

        public static MailMessage CreateMail(string name, string emailfrom, string emailto, string subject, string body)
        {
            var from = new MailAddress(emailfrom, name);
            var to = new MailAddress(emailto);
            var mail = new MailMessage(from, to);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            return mail;

        }
        private void dispatcherTimer_Tick2(object sender, EventArgs e)
        {
            time--;
            button1.Content = "Отменить отправку (" + Convert.ToString(time) + ")";

            if (Global.chouse == 1)//жалоба
            {
                if (time == 0)//конец таймера
                {
                    dispatcherTimer2.Stop();
                    dispatcherTimer.Stop();
                    try
                    {
                        string str1 = "insert into mail_claim(mail_group,mail_writer,mail_text,rate) values(1,'" + Convert.ToString(Global.name) + "','" + Convert.ToString(Global.text) +"',"+ Convert.ToInt32(Global.Rate)+  ");";
                        MySqlConnection conn = Dbu.GetDBConnection();
                        MySqlCommand cmDB = new MySqlCommand(str1, conn);
                        conn.Open();
                        cmDB.ExecuteScalar();
                        conn.Close();



                        var mail = CodeloMail.CreateMail($" От {Global.name}", "juliatestapplication@gmail.com", $"juliatestapplication@gmail.com", $"Жалоба c оценкой: {Global.Rate}", $"{Global.text}") ; //cюда запрос с скл
                        CodeloMail.SendMail("smtp.gmail.com", 587, "kolomeitseva2002@gmail.com", "kjujwsnmiditlejy", mail);
                       



                        MainWindow main = new MainWindow();
                        main.Show();
                        this.Hide();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            if (Global.chouse == 2)//Оценка
            {
                if (time == 0)//конец таймера
                {
                    dispatcherTimer2.Stop();
                    dispatcherTimer.Stop();
                    try
                    {
                        string str1 = "insert into mail_comment(mail_group,mail_writer,mail_text,mail_rate) values(2,'" + Convert.ToString(Global.name) + "','" + Convert.ToString(Global.text) + "'," + Convert.ToInt32(Global.Rate) + ");";
                        MySqlConnection conn = Dbu.GetDBConnection();
                        MySqlCommand cmDB = new MySqlCommand(str1, conn);
                        conn.Open();
                        cmDB.ExecuteScalar();
                        conn.Close();



                        var mail = CodeloMail.CreateMail($" От {Global.name}", "juliatestapplication@gmail.com", $"juliatestapplication@gmail.com", $"Отзыв с оценкой: {Global.Rate}", $"{Global.text}"); //cюда запрос с скл
                        CodeloMail.SendMail("smtp.gmail.com", 587, "kolomeitseva2002@gmail.com", "kjujwsnmiditlejy", mail);



                        MainWindow main = new MainWindow();
                        main.Show();
                        this.Hide();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            dispatcherTimer2.Stop();
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
            Close();
            
        }
    }
}
