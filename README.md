
# BindableTextboxesWPF
Bind your input fields with class fields

## usage
**create a model class for your project**

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

**Set textboxes**

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
