namespace OPPconcepts.Backend
{
    public class HourlyEmployee:Employee
    {
        //fields
        private decimal _hourlyValue;
        private float _workingHours;

        //Constructors

        public HourlyEmployee(int id, string firtsName, string lastName, bool isActive, Date bornDay, Date hireDay, decimal hourlyValue = 0, float workingHours = 0) :
            base(id, firtsName, lastName, isActive, bornDay, hireDay)
        {
            HourlyValue = hourlyValue;
            WorkingHours = workingHours;
        }

        //Properties
        public decimal HourlyValue 
        {
            get => _hourlyValue; 
            set => _hourlyValue = ValidateHourlyValue(value); 
        }
        public float WorkingHours 
        { 
            get => _workingHours; 
            set => _workingHours = ValidateWorkingHours (value); 
        }

        //Methods
        public override decimal GetvalueToPay() =>(decimal)WorkingHours * HourlyValue;
        

        public override string ToString() => base.ToString() + $"\n\t"+ 
            $"Hourly Value: {HourlyValue,20:C2}\n\t" + 
            $"Working Hours: {WorkingHours,20:N2}";

        private decimal ValidateHourlyValue(decimal hourlyValue)
        {
            if (hourlyValue < 10000)
            {
                throw new ArgumentOutOfRangeException(nameof(hourlyValue), "Hourly Value must be greater than or equal to $10.000.");
            }
            return hourlyValue;
        }
        private float ValidateWorkingHours(float workingHours)
        {
            if (workingHours < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(workingHours), "Working Hours must be greater than or equal to 0.");
            }
            return workingHours;
        }
    }
}
