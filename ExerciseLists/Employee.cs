namespace ExerciseLists;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; private set; } = 0;


    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public Employee(int id, string name, double salary) : this(id, name)
    {
        Salary = SetSalary(salary);
    }

    public void IncreaseSalary(double qti)
    {
        Salary += qti;
    }

    private double SetSalary(double value)
    {
        return value;
    }
}