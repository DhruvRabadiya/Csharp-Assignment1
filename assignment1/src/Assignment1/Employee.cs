class Employee
{
    private int id;
    private String Name;
    private String DeptName;
    public Employee(int id, String Name, String DeptName)
    {
        this.id = id;
        this.Name = Name;
        this.DeptName = DeptName;
    }

    public delegate void EventHandler(String msg);

    public event EventHandler callEvent;

    private void onMethodCalled(String EventName)
    {
        callEvent?.Invoke($"{EventName}()method Called");
    }

    public int GetId()
    {
        onMethodCalled("GetId");
        return id;
    }

    public string GetName()
    {
        onMethodCalled("GetName");
        return Name;
    }

    public string GetDeptName()
    {
        onMethodCalled("GetDeptName");
        return DeptName;
    }

    public void setValue(int id)
    {
        this.id = id;
    }

    public void setValue(String name)
    {
        this.Name = name;
    }

    public void setValue(string name, string deptName)
    {
        this.Name = name;
        this.DeptName = deptName;
    }

}

class Program
{
    static void Main(string[] args)
    {
        int id;
        String name;
        String deptName;

        Console.WriteLine("Enter your Id: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Name: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter Your Department:");
        deptName = Console.ReadLine();


        Employee e1 = new Employee(id, name, deptName);
        e1.callEvent += OnMethodCalled;

        Console.WriteLine($"ID: {e1.GetId()}");
        Console.WriteLine($"Name: {e1.GetName()}");
        Console.WriteLine($"Department: {e1.GetDeptName()}");
        e1.setValue(1);
        e1.setValue("Karan", "Sales");
        Console.WriteLine($"\nUpdated values\n");
        Console.WriteLine($"ID: {e1.GetId()}");
        Console.WriteLine($"Name: {e1.GetName()}");
        Console.WriteLine($"Department: {e1.GetDeptName()}");

    }
    static void OnMethodCalled(string message)
    {
        Console.WriteLine(message);
    }
}
