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
using System.Data;
using System.Data.SqlClient;
using System.Windows.Threading;


namespace M.B_MoshaverAmlak
{
    /// <summary>
    /// Interaction logic for frmmostajerin.xaml
    /// </summary>
    public partial class frmmostajerin : Window
    {
        public frmmostajerin()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            conection._conection.Open();

            SqlDataAdapter da = new SqlDataAdapter(porsoju.sqlMs1, conection._conection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgmalekin.ItemsSource = dt.DefaultView;
            conection._conection.Close();




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

        private void btnadd(object sender, RoutedEventArgs e)
        {
            try
            {
                conection._conection.Open();
                SqlCommand c1 = new SqlCommand();
                c1.CommandText = "Insert into mostajer values('" + txtname.Text + "' , '" + txtfamily.Text + "' , '" + txtkodmeli.Text + "' ,'" + txtmobil.Text + "' , '" + txtadres.Text + "')";
                c1.Connection = conection._conection;
                c1.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(porsoju.sqlMs1, conection._conection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgmalekin.ItemsSource = dt.DefaultView;
                conection._conection.Close();
                MessageBox.Show("افزودن با موفقیت انجام شد");

                txtname.Clear();
                txtmobil.Clear();
                txtkodmeli.Clear();
                txtadres.Clear();
                txtfamily.Clear();
            }
            catch
            {
                MessageBox.Show("خطا در اتصال");
            }
        }

        private void btnupdate(object sender, RoutedEventArgs e)
        {
            try
            {
                conection._conection.Open();
                SqlCommand c1 = new SqlCommand();
                //   c1.CommandText = "update mostajer set name='" + txtname.Text + "' , family='" + txtfamily.Text + "' , kodmeli= '" + txtkodmeli.Text + "',mobil= '" + txtmobil.Text + "',adres= '" + txtadres.Text + "' where kodmeli='" + dtgmalekin.CurrentRow.Cells[2].Value.ToString()+"'";
                c1.Connection = conection._conection;
                c1.ExecuteNonQuery();
                conection._conection.Close();
                conection._conection.Open();
                SqlDataAdapter da = new SqlDataAdapter(porsoju.sqlMs1, conection._conection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgmalekin.ItemsSource = dt.DefaultView;

                conection._conection.Close();
                MessageBox.Show("ویرایش با موفقیت انجام شد");
                txtname.Clear();
                txtmobil.Clear();
                txtkodmeli.Clear();
                txtadres.Clear();
                txtfamily.Clear();
            }
            catch
            {
                MessageBox.Show("خطا در اتصال");
            }
        }

        private void btndelet(object sender, RoutedEventArgs e)
        {
            try
            {
                conection._conection.Open();
                SqlCommand c1 = new SqlCommand();
                c1.CommandText = "delete from mostajer where kodmeli='" + txtkodmeli.Text + "'";
                c1.Connection = conection._conection;
                c1.ExecuteNonQuery();
                conection._conection.Close();
                conection._conection.Open();
                SqlDataAdapter da = new SqlDataAdapter(porsoju.sqlMs1, conection._conection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgmalekin.ItemsSource = dt.DefaultView;
                conection._conection.Close();
                MessageBox.Show("حذف با موفقیت انجام شد");
                txtkodmeli.Clear();
            }
            catch
            {
                MessageBox.Show("خطا در اتصال");
            }
        }

        private void txtsearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string sql = "select * from mostajer where kodmeli Like '" + txtsearch.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conection._conection);
            DataTable dt = new DataTable();
            conection._conection.Open();
            da.Fill(dt);
            conection._conection.Close();
            dtgmalekin.ItemsSource = dt.DefaultView; 
        }
    }
}
