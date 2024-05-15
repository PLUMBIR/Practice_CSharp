using System;

class MyInfo
{
    private string _name;

    public event EventHandler NameChanged;

    public string Name
    {
        get { return _name; }
        set
        {
            if (_name != value)
            {
                _name = value;
                OnNameChanged();
            }
        }
    }

    protected virtual void OnNameChanged()
    {
        NameChanged?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyInfo info = new MyInfo();
        info.NameChanged += (sender, eventArgs) => Console.WriteLine("Значение имени изменено.");

        info.Name = "Кирилл";
    }
}
