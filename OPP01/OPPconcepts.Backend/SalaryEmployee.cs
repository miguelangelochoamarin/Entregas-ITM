
namespace OPPconcepts.Backend
{
    public class SalaryEmployee : Employee
    {
       //Fields

        private decimal _salary;
       
        //Constructors           
        public SalaryEmployee(int id, string firtsName, string lastName, bool isActive, Date bornDay, Date hireDay, decimal salary) :
            base(id, firtsName, lastName, isActive, bornDay, hireDay)
        {
            Salary = salary;   
        }
        //properties

        public decimal Salary 
        { 
            get => _salary; 
            set => _salary = ValidateSalary(value); 
        }
        
        //Methods
        public override decimal GetvalueToPay()=> _salary;
        public override string ToString()=>base.ToString();
        
        private decimal ValidateSalary(decimal salary)
        {
            if (salary < 2000000)
            {
                throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to $2.000.000.");
            }
            return salary;
        }
                    
    }
}
