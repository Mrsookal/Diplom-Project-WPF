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

namespace TerminalWpf
{
    /// <summary>
    /// Логика взаимодействия для mail.xaml
    /// </summary>
    public partial class mail : Window
    {
        public mail()
        {
            InitializeComponent();



            Global.lng = 1;
            Global.shift = 2;
            upd();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            textbox1.IsReadOnly = true;
            upd();
        }








        void upd()
        {


            if (Global.shift == 1)
            {
                if (Global.lng == 1) //ру маленькие
                {
                    Butswtchlng.FontSize = 15;
                    Butswtchlng.Content = "ang";
                    Butnumsinvol1.Content = "-";
                    Butq.Content = "й";
                    Butw.Content = "ц";
                    Bute.Content = "у";
                    Butr.Content = "к";
                    Butt.Content = "е";
                    Buty.Content = "н";
                    Butu.Content = "г";
                    Buti.Content = "ш";
                    Buto.Content = "щ";
                    Butp.Content = "з";
                    Butpsimvol1.Content = "х";
                    Butpsimvol2.Content = "ъ";



                    Buta.Content = "ф";
                    Buts.Content = "ы";
                    Butd.Content = "в";
                    Butf.Content = "а";
                    Butg.Content = "п";
                    Buth.Content = "р";
                    Butj.Content = "о";
                    Butk.Content = "л";
                    Butl.Content = "д";
                    Butsimvol3.Content = "ж";
                    Btsimvol4.Content = "э";

                    Butz.Content = "я";
                    Butx.Content = "ч";
                    Butc.Content = "с";
                    Butv.Content = "м";
                    Butb.Content = "и";
                    Butn.Content = "т";
                    Butm.Content = "ь";
                    Butsimvol5.Content = "б";
                    Butsimvol6.Content = "ю";
                }

                else //анг мелнькие
                {
                    Butswtchlng.FontSize = 15;
                    Butswtchlng.Content = "рус";
                    Butnumsinvol1.Content = "-";
                    Butq.Content = "q";
                    Butw.Content = "w";
                    Bute.Content = "e";
                    Butr.Content = "r";
                    Butt.Content = "t";
                    Buty.Content = "y";
                    Butu.Content = "u";
                    Buti.Content = "i";
                    Buto.Content = "o";
                    Butp.Content = "p";
                    Butpsimvol1.Content = "!";
                    Butpsimvol2.Content = "?";



                    Buta.Content = "a";
                    Buts.Content = "s";
                    Butd.Content = "d";
                    Butf.Content = "f";
                    Butg.Content = "g";
                    Buth.Content = "h";
                    Butj.Content = "j";
                    Butk.Content = "k";
                    Butl.Content = "l";
                    Butsimvol3.Content = "(";
                    Btsimvol4.Content = ")";

                    Butz.Content = "z";
                    Butx.Content = "x";
                    Butc.Content = "c";
                    Butv.Content = "v";
                    Butb.Content = "b";
                    Butn.Content = "n";
                    Butm.Content = "m";
                    Butsimvol5.Content = "*";
                    Butsimvol6.Content = "/";



                }
            }
            else
            {
                if (Global.lng == 1) //ру большие
                {
                    Butswtchlng.FontSize = 15;
                    Butswtchlng.Content = "ANG";
                    Butnumsinvol1.Content = "_";
                    Butq.Content = "Й";
                    Butw.Content = "Ц";
                    Bute.Content = "У";
                    Butr.Content = "К";
                    Butt.Content = "Е";
                    Buty.Content = "Н";
                    Butu.Content = "Г";
                    Buti.Content = "Ш";
                    Buto.Content = "Щ";
                    Butp.Content = "З";
                    Butpsimvol1.Content = "Х";
                    Butpsimvol2.Content = "Ъ";



                    Buta.Content = "Ф";
                    Buts.Content = "Ы";
                    Butd.Content = "В";
                    Butf.Content = "А";
                    Butg.Content = "П";
                    Buth.Content = "Р";
                    Butj.Content = "О";
                    Butk.Content = "Л";
                    Butl.Content = "Д";
                    Butsimvol3.Content = "Ж";
                    Btsimvol4.Content = "Э";

                    Butz.Content = "Я";
                    Butx.Content = "Ч";
                    Butc.Content = "С";
                    Butv.Content = "М";
                    Butb.Content = "И";
                    Butn.Content = "Т";
                    Butm.Content = "Ь";
                    Butsimvol5.Content = "Б";
                    Butsimvol6.Content = "Ю";
                }

                else //анг большие
                {
                    Butswtchlng.FontSize = 15;
                    Butswtchlng.Content = "РУС";
                    Butnumsinvol1.Content = "_";
                    Butq.Content = "Q";
                    Butw.Content = "W";
                    Bute.Content = "E";
                    Butr.Content = "R";
                    Butt.Content = "T";
                    Buty.Content = "Y";
                    Butu.Content = "U";
                    Buti.Content = "I";
                    Buto.Content = "O";
                    Butp.Content = "P";
                    Butpsimvol1.Content = "!";
                    Butpsimvol2.Content = "?";



                    Buta.Content = "A";
                    Buts.Content = "S";
                    Butd.Content = "D";
                    Butf.Content = "F";
                    Butg.Content = "G";
                    Buth.Content = "H";
                    Butj.Content = "J";
                    Butk.Content = "K";
                    Butl.Content = "L";
                    Butsimvol3.Content = "(";
                    Btsimvol4.Content = ")";

                    Butz.Content = "Z";
                    Butx.Content = "X";
                    Butc.Content = "C";
                    Butv.Content = "V";
                    Butb.Content = "B";
                    Butn.Content = "N";
                    Butm.Content = "M";
                    Butsimvol5.Content = "*";
                    Butsimvol6.Content = "/";
                }
            }
            if (textbox1.Text.Length <= 5)
            {
                send.IsEnabled = false;
            }
            else
            {
                send.IsEnabled = true;
            }

        }

        private void Buttab_Click(object sender, RoutedEventArgs e) //табуляция
        {
            textbox1.Text += "  ";
            upd();
        }

        private void Butshift_Click(object sender, RoutedEventArgs e) //шифт
        {
            if (Global.shift == 1)
            {
                Global.shift++;
            }
            else
            {
                Global.shift--;
            }
            upd();
        }


        private void Butspase_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += " ";
        }

        private void Butnum0_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "0";
        }

        private void Butnum1_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "1";
        }

        private void Butnum2_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "2";
        }

        private void Butnum3_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "3";
        }

        private void Butnum4_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "4";
        }

        private void Butnum5_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "5";
        }

        private void Butnum6_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "6";
        }

        private void Butnum7_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "7";
        }

        private void Butnum8_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "8";
        }

        private void Butnum9_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "9";
        }

        private void Butdelete_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.Length > 0)
            {
                textbox1.Text = textbox1.Text.Remove(textbox1.Text.Length - 1);
            }
        }

        private void Butq_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "й";

                }
                else
                {
                    textbox1.Text += "Й";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "q";

                }
                else
                {
                    textbox1.Text += "Q";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butw_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "ц";

                }
                else
                {
                    textbox1.Text += "Ц";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "w";

                }
                else
                {
                    textbox1.Text += "W";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Bute_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "у";

                }
                else
                {
                    textbox1.Text += "У";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "e";

                }
                else
                {
                    textbox1.Text += "E";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butr_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "к";

                }
                else
                {
                    textbox1.Text += "К";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "r";

                }
                else
                {
                    textbox1.Text += "R";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butt_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "е";

                }
                else
                {
                    textbox1.Text += "Е";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "t";

                }
                else
                {
                    textbox1.Text += "T";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Buty_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "н";

                }
                else
                {
                    textbox1.Text += "Н";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "y";

                }
                else
                {
                    textbox1.Text += "Y";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butu_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "г";

                }
                else
                {
                    textbox1.Text += "Г";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "u";

                }
                else
                {
                    textbox1.Text += "U";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Buti_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "ш";

                }
                else
                {
                    textbox1.Text += "Ш";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "i";

                }
                else
                {
                    textbox1.Text += "I";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Buto_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "щ";

                }
                else
                {
                    textbox1.Text += "Щ";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "o";

                }
                else
                {
                    textbox1.Text += "O";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butp_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "з";

                }
                else
                {
                    textbox1.Text += "З";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "p";

                }
                else
                {
                    textbox1.Text += "P";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butnumsinvol1_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "-";

                }
                else
                {
                    textbox1.Text += "_";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "-";

                }
                else
                {
                    textbox1.Text += "_";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butnumsinvol2_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "=";

                }
                else
                {
                    textbox1.Text += "+";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "=";

                }
                else
                {
                    textbox1.Text += "+";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butpsimvol1_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "х";

                }
                else
                {
                    textbox1.Text += "Х";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "?";

                }
                else
                {
                    textbox1.Text += "?";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butpsimvol2_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "ъ";

                }
                else
                {
                    textbox1.Text += "Ъ";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "!";

                }
                else
                {
                    textbox1.Text += "!";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butenter_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += Environment.NewLine;
        }

        private void Butswtchlng_Click(object sender, RoutedEventArgs e) //Cмена языка
        {

            if (Global.shift == 1)
            {
                if (Global.lng == 2) //ру маленькие
                {
                    Global.lng--;
                    upd();
                }

                else //анг мелнькие
                {
                    Global.lng++;

                    upd();


                }
            }
            else
            {
                if (Global.lng == 2) //ру большие
                {
                    Global.lng--;

                    upd();
                }

                else //анг большие
                {
                    Global.lng++;

                    upd();
                }
            }


        }

        private void Buta_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "ф";

                }
                else
                {
                    textbox1.Text += "Ф";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "a";

                }
                else
                {
                    textbox1.Text += "A";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Buts_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "ы";

                }
                else
                {
                    textbox1.Text += "Ы";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "s";

                }
                else
                {
                    textbox1.Text += "S";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butd_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "в";

                }
                else
                {
                    textbox1.Text += "В";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "d";

                }
                else
                {
                    textbox1.Text += "D";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butf_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "а";

                }
                else
                {
                    textbox1.Text += "А";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "f";

                }
                else
                {
                    textbox1.Text += "F";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butg_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "п";

                }
                else
                {
                    textbox1.Text += "П";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "g";

                }
                else
                {
                    textbox1.Text += "G";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Buth_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "р";

                }
                else
                {
                    textbox1.Text += "Р";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "h";

                }
                else
                {
                    textbox1.Text += "H";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butj_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "о";

                }
                else
                {
                    textbox1.Text += "О";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "j";

                }
                else
                {
                    textbox1.Text += "J";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butk_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "л";

                }
                else
                {
                    textbox1.Text += "Л";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "k";

                }
                else
                {
                    textbox1.Text += "K";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butl_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "д";

                }
                else
                {
                    textbox1.Text += "Д";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "l";

                }
                else
                {
                    textbox1.Text += "L";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butsimvol3_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "ж";

                }
                else
                {
                    textbox1.Text += "Ж";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "(";

                }
                else
                {
                    textbox1.Text += "(";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Btsimvol4_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "э";

                }
                else
                {
                    textbox1.Text += "Э";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += ")";

                }
                else
                {
                    textbox1.Text += ")";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butz_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "я";

                }
                else
                {
                    textbox1.Text += "Я";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "z";

                }
                else
                {
                    textbox1.Text += "Z";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butx_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "ч";

                }
                else
                {
                    textbox1.Text += "Ч";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "x";

                }
                else
                {
                    textbox1.Text += "X";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butc_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "с";

                }
                else
                {
                    textbox1.Text += "С";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "c";

                }
                else
                {
                    textbox1.Text += "C";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butv_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "м";

                }
                else
                {
                    textbox1.Text += "М";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "v";

                }
                else
                {
                    textbox1.Text += "V";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butb_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "и";

                }
                else
                {
                    textbox1.Text += "И";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "b";

                }
                else
                {
                    textbox1.Text += "B";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butn_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "т";

                }
                else
                {
                    textbox1.Text += "Т";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "n";

                }
                else
                {
                    textbox1.Text += "N";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butm_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "ь";

                }
                else
                {
                    textbox1.Text += "Ь";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "m";

                }
                else
                {
                    textbox1.Text += "M";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butsimvol5_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "б";

                }
                else
                {
                    textbox1.Text += "Б";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "*";

                }
                else
                {
                    textbox1.Text += "*";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butsimvol6_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "ю";

                }
                else
                {
                    textbox1.Text += "Ю";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += "/";

                }
                else
                {
                    textbox1.Text += "/";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butsimvol7_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += ",";

                }
                else
                {
                    textbox1.Text += ",";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += ",";

                }
                else
                {
                    textbox1.Text += ",";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Butsimvol8_Click(object sender, RoutedEventArgs e)
        {
            if (Global.lng == 1)
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += ".";

                }
                else
                {
                    textbox1.Text += ".";
                    Global.shift--;

                }

            }
            else
            {
                if (Global.shift == 1)
                {
                    textbox1.Text += ".";

                }
                else
                {
                    textbox1.Text += ".";
                    Global.shift--;
                }

            }
            upd();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Global.Rate = Convert.ToInt32(Slider.Value);
            Global.text = textbox1.Text;
            Final final = new Final();
            final.Show();
            this.Hide();
            Close();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {


            double slider = Slider.Value;
            if (slider == 1)
            {

                img1.Visibility = Visibility.Visible;
                img2.Visibility = Visibility.Hidden;
                img3.Visibility = Visibility.Hidden;
                img4.Visibility = Visibility.Hidden;
                img5.Visibility = Visibility.Hidden;

                Slider.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 0));
            }
            if (slider == 2)
            {
                img1.Visibility = Visibility.Hidden;
                img2.Visibility = Visibility.Visible;
                img3.Visibility = Visibility.Hidden;
                img4.Visibility = Visibility.Hidden;
                img5.Visibility = Visibility.Hidden;

                Slider.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 200, 0));
            }
            if (slider == 3)
            {
                img1.Visibility = Visibility.Hidden;
                img2.Visibility = Visibility.Hidden;
                img3.Visibility = Visibility.Visible;
                img4.Visibility = Visibility.Hidden;
                img5.Visibility = Visibility.Hidden;

                Slider.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 155, 0));
            }
            if (slider == 4)
            {
                img1.Visibility = Visibility.Hidden;
                img2.Visibility = Visibility.Hidden;
                img3.Visibility = Visibility.Hidden;
                img4.Visibility = Visibility.Visible;
                img5.Visibility = Visibility.Hidden;

                Slider.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 100, 0));
            }
            if (slider == 5)
            {
                img1.Visibility = Visibility.Hidden;
                img2.Visibility = Visibility.Hidden;
                img3.Visibility = Visibility.Hidden;
                img4.Visibility = Visibility.Hidden;
                img5.Visibility = Visibility.Visible;

                Slider.Foreground = new SolidColorBrush(Color.FromArgb(255, 255,0, 0));
            }

        }

        private void buttback_Click(object sender, RoutedEventArgs e)
        {
            Zhaloba zhaloba = new Zhaloba();
            zhaloba.Show();
            this.Hide();
            Close();
        }
    }
    
}

 
