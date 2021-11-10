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

namespace AppEvents
{
    /// <summary>
    /// Логика взаимодействия для Message.xaml
    /// </summary>
    public partial class Message : Window
    {
        public List<FederalDistricts> federalDistricts = new List<FederalDistricts>();
        public List<Categories> categories = new List<Categories>();
        public Message()
        {
            InitializeComponent();
            var listMessage = Helper.GetContext().FederalDistricts.ToList();
            CBFed.ItemsSource = listMessage;
            using (EventContainer db = new EventContainer())
            {
                federalDistricts.Clear();
                federalDistricts = db.FederalDistricts.ToList();
                CBFed.ItemsSource = federalDistricts;
                CBFed.DisplayMemberPath = "FederalDistrict";
                CBFed.SelectedValuePath = "IdFederalDistrict";
               
            }
            var listCategories = Helper.GetContext().Categories.ToList();
            CBKat.ItemsSource = listCategories;
            using (EventContainer db = new EventContainer())
            {
                categories.Clear();
                categories = db.Categories.ToList();
                CBKat.ItemsSource = categories;
                CBKat.DisplayMemberPath = "CategoryName";
                CBKat.SelectedValuePath = "IdCategory";
                
            }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ButtonPodOb_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
