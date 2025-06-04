using KursISP21.Model;
using KursISP21.Views.Pages;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KursISP21;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        KursovayaContext db = new KursovayaContext();
        PageFrame.Navigate(new StartPage());
    }

    private void Label_MouseDown(object sender, MouseButtonEventArgs e)
    {
        PageFrame.Navigate(new StartPage());
    }

    private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
    {
        PageFrame.Navigate(new AuthorPage());
    }

    private void Label_MouseDown_2(object sender, MouseButtonEventArgs e)
    {
        PageFrame.Navigate(new CustomerPage());
    }

    private void Label_MouseDown_3(object sender, MouseButtonEventArgs e)
    {
        PageFrame.Navigate(new PrintinghousePage());
    }

    private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
    {
        PageFrame.Navigate(new OrderPage());
    }
        
    private void Label_MouseDown_5(object sender, MouseButtonEventArgs e)
    {
        PageFrame.Navigate(new CustomerPage());
    }
}