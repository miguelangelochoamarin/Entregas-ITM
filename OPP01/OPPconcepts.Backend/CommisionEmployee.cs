namespace OPPconcepts.Backend;
public class CommisionEmployee : Employee
{
    //Fields
    private float _commisionPercent;

    public CommisionEmployee(float commisionPercent, decimal sales)
    {
        _commisionPercent = commisionPercent;
        Sales = sales;
    }

    private decimal _sales;


    //Constructor

    public CommisionEmployee(int id, string firtsName, string lastName, bool isActive, Date bornDay, Date hireDay, float commisionPercent, decimal sales) : 
        base(id, firtsName, lastName, isActive, bornDay, hireDay)
    {

    }
    
    //Properties
    public float CommisionPercent
    {
        get => _commisionPercent;
        set => _commisionPercent = ValidateCommisionPercent(value);
    }
    public decimal Sales
    { 
        get => _sales;
        set => _sales = ValidateSales(value);
    }
    //Methods
    public override decimal GetvalueToPay() => (decimal)CommisionPercent * Sales;


    public override string ToString() => base.ToString() + $"\n\t" +
        $"Commision percent: {CommisionPercent,20:P2}\n\t" +
        $"Sales......... {Sales,20:C2}";

    private float ValidateCommisionPercent(float commisionPercent)
    {
        {
            if (CommisionPercent < 0 || commisionPercent > 1)
                throw new ArgumentOutOfRangeException(nameof(commisionPercent), " Commision Percent must be betwen 0 and 1.");
        }
        return CommisionPercent;
    }
    private decimal ValidateSales(decimal sales) 
    { 
        if(sales<0)

            { throw new ArgumentOutOfRangeException(nameof(sales), "Sales must be greater than or equal to 0.");
        }
        return sales;   
    }
}
