using System.Windows.Controls;

namespace WpfApp1
{
    public abstract class EditBase
    {
        public class Property<T>
        {
            public string Key { get; set; }
            public T Value { get; private set; }
            public TextBox TextBox { get; private set; }
            public Property(string key, T value)
            {
                Key = key;
                Value = value;
            }
            public void OnPropertyChanged(string value)
            {
                if (TextBox != null)
                    TextBox.Text = value;
            }
            public void SetTextBox(TextBox textBox)
            {
                TextBox = textBox;
                TextBox.Text = Value.ToString();
            }
            public void SetValue(T value)
            {
                Value = value;
                OnPropertyChanged(Value.ToString());
            }
        }
    }
}
