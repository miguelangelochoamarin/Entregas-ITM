using OPPconcepts.Backend;

try
{
    var employees = new List<Employee>();
    decimal payroll = 0;
    var employee1 = new SalaryEmployee(1010,"Maria","Perez", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    employees.Add(employee1);   
    var employee2 = new SalaryEmployee(2020, "Joaquin", "Gonzalez", true, new Date(1980, 5, 15), new Date(2020, 1, 1), 10395876);
    employees.Add(employee2);  
    var employee3 = new HourlyEmployee(2030, "Ana", "Lopez", true, new Date(1980, 5, 15), new Date(2020, 1, 1), 18000,95);
    employees.Add(employee3);
    var employee4 = new HourlyEmployee(2040, "Kevin", "Cardona", true, new Date(1980, 5, 15), new Date(2020, 1, 1), 10000, 112);
    employees.Add(employee4);
    var employee5 = new CommisionEmployee(2050, "Sofia", "Gomez", true, new Date(1988, 2, 18), new Date(2001, 1, 1), 0.03f, 600000000);
    employees.Add(employee5);
    var employee6 = new CommisionEmployee(2060, "Diego", "Martinez", true, new Date(1985, 9, 9), new Date(2013, 1, 1), 0.03f, 120000000);
    employees.Add(employee6);
    var employee7 = new BaseCommisionEmployee(2070, "Laura", "garcia", true, new Date(1972, 5, 24), new Date(2015, 2, 3), 0.015f,2500000000, 550000);
    employees.Add(employee7);
    var employee8 = new BaseCommisionEmployee(2080, "Sofia", "garcia",    true, new Date(1972, 5, 24), new Date(2015, 2, 3), 0.015f, 0, 550000);
    employees.Add(employee8);



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

