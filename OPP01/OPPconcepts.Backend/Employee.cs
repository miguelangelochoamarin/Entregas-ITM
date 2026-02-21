using System;
using System.Collections.Generic;
using System.Text;

namespace OPPconcepts.Backend;


public abstract class Employee
{
    //Constructors
    public Employee() 
        { 
    }

    public Employee(int id, string firtsName, string lastName, bool isActive, Date bornDay, Date hireDay)
    {
        Id = id;
        FirtsName = firtsName;
        LastName = lastName;
        IsActive = isActive;
        BornDay = bornDay;
        HireDay = hireDay;
    }

    

   
    //properties
    public int Id { get; set; }
    public string FirtsName { get; set; } = null!;
    public String LastName { get; set; } = null!;
    public bool IsActive { get; set; }
    public Date BornDay { get; set; } = null!;
    public Date HireDay { get; set; } = null!;

    //Methods
    public override string ToString()
    {
        return  $"(Id)/t(firstName) (Lastname) /n/t" +
                $"Value to pay: {GetvalueToPay()}";
    }
    public abstract decimal GetvalueToPay();
    
}
