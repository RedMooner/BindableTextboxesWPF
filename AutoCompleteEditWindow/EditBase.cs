using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// the base class for creating EditBase. 
    /// Inherit this class in your project's model class
    /// </summary>
    public abstract class EditBase
    {
        /// <summary>
        /// The main class is a property.
        /// Generalized by type T as a class. 
        /// Create properties in your model class that will be an instance of this class for automatically changing textboxes.
        /// </summary>
        /// <typeparam name="T">T is an some model class</typeparam>
        public class Property<T>
        {
            /// <summary>
            /// Property Key
            /// </summary>
            public string Key { get; set; }
            /// <summary>
            /// Property value (most often string)
            /// </summary>
            public T Value { get; private set; }
            /// <summary>
            /// The textbox inherent in this property
            /// </summary>
            public TextBox TextBox { get; private set; }
            /// <summary>
            /// constructor of a new property
            /// </summary>
            /// <param name="key">Property Key</param>
            /// <param name="value">Property value</param>
            public Property(string key, T value)
            {
                Key = key;
                Value = value;
            }
            /// <summary>
            /// The method that sets the value of the property in the textbox
            /// </summary>
            /// <param name="value">some value</param>
            public void OnPropertyChanged(string value)
            {
                if (TextBox != null)
                    TextBox.Text = value;
            }
            /// <summary>
            /// Method that sets the textbox for this property
            /// </summary>
            /// <param name="textBox">textbox</param>
            public void SetTextBox(TextBox textBox)
            {
                TextBox = textBox;
                TextBox.Text = Value.ToString();
            }
            /// <summary>
            /// Method that sets the value of the property
            /// </summary>
            /// <param name="value">some value</param>
            public void SetValue(T value)
            {
                Value = value;
                OnPropertyChanged(Value.ToString());
            }
        }
    }
}
