namespace WpfApp1
{
    /// <summary>
    /// the main interface - implement in your window
    /// </summary>
    /// <typeparam name="T">Some class model</typeparam>
    public interface IEditWindowBase<T> where T : class
    {
        /// <summary>
        /// Object of the model class
        /// </summary>
        T EntityValue { get; set; }
    }
}
