using OPPconcepts.Backend;

try
{
    var employee1 = new SalaryEmployee(1010,"Maria","Perez", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    var employee2 = new SalaryEmployee(2010, "Joaquin", "Gonzalez", true, new Date(1980, 5, 15), new Date(2020, 1, 1), 10395876);
    var employee3 = new HourlyEmployee(2030, "Ana", "Lopez", true, new Date(1980, 5, 15), new Date(2020, 1, 1), 1500,160);

    Console.WriteLine(employee1);
    Console.WriteLine(employee2);
    Console.WriteLine(employee3);
}
catch   (Exception ex)
{
    Console.WriteLine(ex.Message);
}

