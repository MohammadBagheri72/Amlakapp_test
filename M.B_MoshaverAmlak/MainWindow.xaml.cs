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
using System.Windows.Threading;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Server;
using System.Windows.Input;

namespace M.B_MoshaverAmlak
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblruzhafte.Content = persiancalender.SelectedDate.PersianDayOfWeek;
            lblruzmah.Content = persiancalender.SelectedDate.Day;
            lblmah.Content = persiancalender.SelectedDate.MonthAsPersianMonth;
            lblsal.Content = persiancalender.SelectedDate.Year;
                lblmin.Content = DateTime.Now.Minute;
                lblhour.Content = DateTime.Now.Hour;
              DispatcherTimer timer = new DispatcherTimer();
              timer.Tick += new EventHandler(seck);
              timer.Interval = new TimeSpan(0, 0, 0, 0, 600);
              timer.Start();
            
        }


        private void seck(object sender, EventArgs e)
        {
            
            lblmin.Content = DateTime.Now.Minute;
            lblhour.Content = DateTime.Now.Hour;
            if (lblseck.Visibility == System.Windows.Visibility.Hidden)
                lblseck.Visibility = Visibility.Visible;
            else
                lblseck.Visibility = Visibility.Hidden;

        }
        private void btnmalekin(object sender, RoutedEventArgs e)
        {
            Malekin m = new Malekin();
            m.Show();
     


        }
        private void btnkharidar(object sender, RoutedEventArgs e)
        {
            frmkharidar m = new frmkharidar();
            m.Show();

        }
        private void btnmostajer(object sender, RoutedEventArgs e)
        {
            frmmostajerin m = new frmmostajerin();
            m.Show();

        }
        private void btnkhane(object sender, RoutedEventArgs e)
        {
            frmkhane m = new frmkhane();
            m.Show();

        }
        private void btnapartman(object sender, RoutedEventArgs e)
        {
            frmapartman m = new frmapartman();
            m.Show();

        }
        private void btnzamin(object sender, RoutedEventArgs e)
        {
            frmzamin m = new frmzamin();
            m.Show();

        }
        private void btnmaghaze(object sender, RoutedEventArgs e)
        {
            frmmaghaze m = new frmmaghaze();
            m.Show();

        }
        private void btnEkhane(object sender, RoutedEventArgs e)
        {
            frmezarezamin m = new frmezarezamin();
            m.Show();

        }
        private void btnEapartman(object sender, RoutedEventArgs e)
        {
            frmEjareApartman m = new frmEjareApartman();
            m.Show();

        }
        private void btnEmaghaze(object sender, RoutedEventArgs e)
        {
            frmEjareMaghaze m = new frmEjareMaghaze();
            m.Show();

        }
        private void btnKHkhane(object sender, RoutedEventArgs e)
        {
            frmKharidKhane m = new frmKharidKhane();
            m.Show();

        }
        private void btnKHapartman(object sender, RoutedEventArgs e)
        {
            frmKharidApartman m = new frmKharidApartman();
            m.Show();

        }
        private void btnKHmaghaze(object sender, RoutedEventArgs e)
        {
            frmKharidMaghaze m = new frmKharidMaghaze();
            m.Show();

        }
        private void btnKhHzamin(object sender, RoutedEventArgs e)
        {
            frmKharidZamin m = new frmKharidZamin();
            m.Show();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnetelaatekarbordi(object sender, RoutedEventArgs e)
        {
            frmetelaatkarbordi f = new frmetelaatkarbordi();
            f.Show();
        }

        private void btnbackup(object sender, RoutedEventArgs e)
        {
            conection._conection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "exec mohammadd";
            cmd.Connection = conection._conection;
            conection._conection.Close();


           MessageBox.Show("عملیات پشتیبان گیری با موفقیت انجام شد");
        }

        private void btnrestor(object sender, RoutedEventArgs e)
        {
            string qry1;


      qry1 = " RESTORE DATABASE Moshaver_Amlak FROM DISK='" + @"h:\\backup.bak" + "'";

     SqlConnection con = new SqlConnection("Data Source=.;database=Moshaver_Amlak;Integrated Security=True");

      con.Open();



      SqlCommand com = new SqlCommand(qry1, con);

     com.ExecuteNonQuery();

      con.Close();

MessageBox.Show("عملیات برگرداندن نسخه پشتیبان با موفقیت انجام شد");
        }

    }
}
