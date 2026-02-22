using OPPconcepts.Backend;

try
{
    var employees = new List<Employee>();
    decimal payroll = 0;
    var employee1 = new SalaryEmployee(1010,"Maria","Perez", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    employees.Add(employee1);   
    var employee2 = new SalaryEmployee(2010, "Joaquin", "Gonzalez", true, new Date(1980, 5, 15), new Date(2020, 1, 1), 10395876);
    employees.Add(employee2);  
    var employee3 = new HourlyEmployee(2030, "Ana", "Lopez", true, new Date(1980, 5, 15), new Date(2020, 1, 1), 18000,95);
    employees.Add(employee3);
    var employee4 = new HourlyEmployee(2030, "Kevin", "Cardona", true, new Date(1980, 5, 15), new Date(2020, 1, 1), 10000, 112);
    employees.Add(employee4);
    foreach ( var employee in employees )
    {       
        Console.WriteLine(new string('-',47));

        Console.WriteLine(employee);
        payroll += employee.GetvalueToPay();
    }
    Console.WriteLine(new string('-', 47));
    Console.WriteLine($"Payroll.............: { payroll,25:C2}");
}
catch   (Exception ex)
{
    Console.WriteLine(ex.Message);
}

