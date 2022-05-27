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
using Stimulsoft.Report;

namespace M.B_MoshaverAmlak
{
    /// <summary>
    /// Interaction logic for frmviewejarekhane.xaml
    /// </summary>
    public partial class frmviewejarekhane : Window
    {
        public frmviewejarekhane()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            conection._conection.Open();

            SqlDataAdapter da = new SqlDataAdapter(porsoju.sqlvkh1, conection._conection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgmalekin.ItemsSource = dt.DefaultView;
            conection._conection.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StiReport sti = new StiReport();
            sti.Load("");
            sti.Show();
        }
    }
}
