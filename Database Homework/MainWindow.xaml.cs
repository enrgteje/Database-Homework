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
using System.Data.OleDb;
using System.Runtime.Remoting.Channels;

namespace Database_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection cn;
        public MainWindow()
        {
            string Conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CW6.accdb";
            cn = new OleDbConnection(Conn);

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "select * from Assets";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";
            while(read.Read())
            {
                data += read[0].ToString() + " ";
                data += read[1].ToString() + " ";
                data += read[2].ToString() + "\n";
            }
            table.Text = data;
            cn.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Database_Homework.CW6DataSet cW6DataSet = ((Database_Homework.CW6DataSet)(this.FindResource("cW6DataSet")));
            // Load data into the table Assets. You can modify this code as needed.
            Database_Homework.CW6DataSetTableAdapters.AssetsTableAdapter cW6DataSetAssetsTableAdapter = new Database_Homework.CW6DataSetTableAdapters.AssetsTableAdapter();
            cW6DataSetAssetsTableAdapter.Fill(cW6DataSet.Assets);
            System.Windows.Data.CollectionViewSource assetsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("assetsViewSource")));
            assetsViewSource.View.MoveCurrentToFirst();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            Database_Homework.CW6DataSet cW6DataSet = ((Database_Homework.CW6DataSet)(this.FindResource("cW6DataSet")));
            // Load data into the table Assets. You can modify this code as needed.
            Database_Homework.CW6DataSetTableAdapters.AssetsTableAdapter cW6DataSetAssetsTableAdapter = new Database_Homework.CW6DataSetTableAdapters.AssetsTableAdapter();
            cW6DataSetAssetsTableAdapter.Fill(cW6DataSet.Assets);
            System.Windows.Data.CollectionViewSource assetsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("assetsViewSource")));
            assetsViewSource.View.MoveCurrentToFirst();
        }

        private void Window_Loaded_2(object sender, RoutedEventArgs e)
        {

            Database_Homework.CW6DataSet cW6DataSet = ((Database_Homework.CW6DataSet)(this.FindResource("cW6DataSet")));
            // Load data into the table Employees. You can modify this code as needed.
            Database_Homework.CW6DataSetTableAdapters.EmployeesTableAdapter cW6DataSetEmployeesTableAdapter = new Database_Homework.CW6DataSetTableAdapters.EmployeesTableAdapter();
            cW6DataSetEmployeesTableAdapter.Fill(cW6DataSet.Employees);
            System.Windows.Data.CollectionViewSource employeesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("employeesViewSource")));
            employeesViewSource.View.MoveCurrentToFirst();
        }

        private void employeesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded_3(object sender, RoutedEventArgs e)
        {

            Database_Homework.CW6DataSet cW6DataSet = ((Database_Homework.CW6DataSet)(this.FindResource("cW6DataSet")));
            // Load data into the table Assets. You can modify this code as needed.
            Database_Homework.CW6DataSetTableAdapters.AssetsTableAdapter cW6DataSetAssetsTableAdapter = new Database_Homework.CW6DataSetTableAdapters.AssetsTableAdapter();
            cW6DataSetAssetsTableAdapter.Fill(cW6DataSet.Assets);
            System.Windows.Data.CollectionViewSource assetsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("assetsViewSource")));
            assetsViewSource.View.MoveCurrentToFirst();
            // Load data into the table Employees. You can modify this code as needed.
            Database_Homework.CW6DataSetTableAdapters.EmployeesTableAdapter cW6DataSetEmployeesTableAdapter = new Database_Homework.CW6DataSetTableAdapters.EmployeesTableAdapter();
            cW6DataSetEmployeesTableAdapter.Fill(cW6DataSet.Employees);
            System.Windows.Data.CollectionViewSource employeesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("employeesViewSource")));
            employeesViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string query = "select * from Employees";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";
            while (read.Read())
            {
                data += read[0].ToString() + " ";
                data += read[1].ToString() + " ";
                data += read[2].ToString() + "\n";
            }
            table.Text = data;
            cn.Close();
        }
    }
}
