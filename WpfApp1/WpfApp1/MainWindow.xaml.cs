using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public class person : EditBase
    {
        public Property<string> name = new Property<string>("name", "some name");
        public string Name
        {
            get
            {
                return name.Value;
            }
            set
            {
                name.SetValue(value);
            }
        }
        public person(string name)
        {
            Name = name;
        }
     
    }
    public partial class MainWindow : Window, IEditWindowBase<person>
    {
        public person EntityValue { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.EntityValue = new person("Саша Мотырев");
            EntityValue.name.SetTextBox(testlabel);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EntityValue.Name = "TEST";
        }
    }
}
