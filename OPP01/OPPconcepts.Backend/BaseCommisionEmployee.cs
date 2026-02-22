namespace OPPconcepts.Backend;

public class BaseCommisionEmployee: CommisionEmployee
{
    //Fields
    private decimal _salary;

    //Constructors
    public BaseCommisionEmployee(int id, string firtsName, string lastName, bool isActive, Date bornDay, Date hireDay, float commisionPercent, decimal sales, decimal salary) :
        base(id, firtsName, lastName, isActive, bornDay, hireDay, commisionPercent, sales)
    {
        Salary = salary;
    }





    //Properties
    public decimal Salary
    { 
        get => _salary; 
        set => _salary =ValidateSalary(value);
    }


    //Method

    public override decimal GetvalueToPay()=>  base.GetvalueToPay() + Salary;

    public override string ToString() =>  $"{base.ToString()} " + $"\n\tSalary baase...:(Salary,20:C2)";
    
    
    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 500000)
        {
            throw new ArgumentOutOfRangeException(nameof(salary), "Salary base must be greater than or equal to $2.000.000.");
        }
        return salary;
    }
}
