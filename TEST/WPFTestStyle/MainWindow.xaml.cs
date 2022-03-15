using System;
using System.Collections.Generic;
using System.Data;
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

namespace WPFTestStyle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataTable dataTable = new DataTable();

        public MainWindow()
        {
            InitializeComponent();
            SortedSet();
        }
        
        public void SortedSet()
        {
            
            DateTime date = new DateTime(2022, 3, 9);
            DateTime datef = new DateTime(2022, 3, 11);
            while (date < datef)
            {
                date = date.AddDays(1);
                dataTable.Columns.Add(Convert.ToString(date), typeof(string));
            }
            dataTable.Rows.Add(typeof(string));
            dataTable.Rows.Add(typeof(string));
            dataTable.Rows.Add("wdadw","wdawdaws");
            sd.DataContext = dataTable.DefaultView;
            
        }
    }
}
