using KursISP21.Model;
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

namespace KursISP21.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorEditPage.xaml
    /// </summary>
    public partial class AuthorEditPage : Page
    {
        public Author Author { get; private set; }
        public AuthorEditPage(Author author)
        {
            InitializeComponent();
            Author = author;
            DataContext = Author;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (KursovayaContext db = new KursovayaContext())
            {
                db.Authors.AddAsync(Author);
                db.SaveChangesAsync();
                this.NavigationService.GoBack();
            }
        }
    }
}
