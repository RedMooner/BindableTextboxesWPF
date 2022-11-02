namespace WpfApp1
{
    public interface IEditWindowBase<T> where T : class
    {
        T EntityValue { get; set; }
    }
}
