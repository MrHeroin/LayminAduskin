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
namespace Laymin
{

    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        public object Connect { get; private set; }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            var logging = Connect.ConnectionClass.Context.Employee.Where(i => i.Login == Log1.Text && i.Password == Pas1.Password).FirstOrDefault();

            switch (logging.IdRoll)
            {
                case 1:
                    DocWindow DW = new DocWindow();
                    DW.Show();
                    Application.Current.MainWindow.Close();
                    break;
                case 2:
                    DocWindow AW = new DocWindow();
                    AW.Show();
                    Application.Current.MainWindow.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
