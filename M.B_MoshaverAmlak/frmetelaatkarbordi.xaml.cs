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
using System.Windows.Threading;
using System.Data;
using System.Data.SqlClient;

namespace M.B_MoshaverAmlak
{
    /// <summary>
    /// Interaction logic for frmetelaatkarbordi.xaml
    /// </summary>
    public partial class frmetelaatkarbordi : Window
    {
        public frmetelaatkarbordi()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            lblruzemah.Content = m.persiancalender.SelectedDate.Day;
            lblmah.Content = m.persiancalender.SelectedDate.MonthAsPersianMonth;
            lblsal.Content = m.persiancalender.SelectedDate.Year;
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

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            conection._conection.Open();
            SqlDataAdapter da = new SqlDataAdapter("exec _pro1", conection._conection);
            DataTable dt = new DataTable();
            da.Fill(dt);
           dtgmalekin .ItemsSource = dt.DefaultView;

           conection._conection.Close();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            conection._conection.Open();
            SqlDataAdapter da = new SqlDataAdapter("exec _pro22", conection._conection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgmalekin.ItemsSource = dt.DefaultView;

            conection._conection.Close();
        }
       

        private void Label_MouseDown_10(object sender, MouseButtonEventArgs e)
        {
            conection._conection.Open();
            SqlDataAdapter da = new SqlDataAdapter("exec _pro3", conection._conection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgmalekin.ItemsSource = dt.DefaultView;

            conection._conection.Close();
        }

        private void Label_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            conection._conection.Open();
            SqlDataAdapter da = new SqlDataAdapter("exec _pro4", conection._conection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgmalekin.ItemsSource = dt.DefaultView;

            conection._conection.Close();
        }

        private void Label_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            conection._conection.Open();
            SqlDataAdapter da = new SqlDataAdapter("exec _pro5", conection._conection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgmalekin.ItemsSource = dt.DefaultView;

            conection._conection.Close();
        }

        private void Label_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            conection._conection.Open();
            SqlDataAdapter da = new SqlDataAdapter("exec _pro6", conection._conection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgmalekin.ItemsSource = dt.DefaultView;

            conection._conection.Close();
        }

        private void Label_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            conection._conection.Open();
            SqlDataAdapter da = new SqlDataAdapter("exec _pro7", conection._conection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgmalekin.ItemsSource = dt.DefaultView;

            conection._conection.Close();
        }

        private void Label_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            conection._conection.Open();
            SqlDataAdapter da = new SqlDataAdapter("exec _pro8", conection._conection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgmalekin.ItemsSource = dt.DefaultView;

            conection._conection.Close();
        }

        private void Label_MouseDown_7(object sender, MouseButtonEventArgs e)
        {
            conection._conection.Open();
            SqlDataAdapter da = new SqlDataAdapter("exec _pro9", conection._conection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgmalekin.ItemsSource = dt.DefaultView;

            conection._conection.Close();
        }

        private void Label_MouseDown_8(object sender, MouseButtonEventArgs e)
        {
            conection._conection.Open();
            SqlDataAdapter da = new SqlDataAdapter("exec _pro10", conection._conection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgmalekin.ItemsSource = dt.DefaultView;

            conection._conection.Close();
        }
    }
}
