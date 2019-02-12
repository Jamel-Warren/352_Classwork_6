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

namespace Classwork_6
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

        private void Asset_Button_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection cn;
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database.accdb");
            string query = "select* from Assets";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";
            while (read.Read())
            {
                data += read[0].ToString() + ", " + read[1].ToString() + ", " + read[2].ToString() + "\n";
            }
            employee_text.Text = data;
        }

        private void Employee_button_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection cn;
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database.accdb");
            string query = "select* from Employees";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";
            while (read.Read())
            {
                data += read[0].ToString() + ", " +  read[1].ToString() + ", " + read[2].ToString() + "\n";
            }
            employee_Text.Text = data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            employee_Text.Text = String.Empty;
            employee_text.Text = String.Empty;
        }
    }
}
