﻿namespace EmployeeManagerCSharp
{
  class Employee
  {
    private int employeeNum;
    public int EmployeeNum
    {
      get { return employeeNum; }
      set { employeeNum = value; }
    }

    public string name { get; set; }

    public Employee(int employeeNum, string name)
    {
      this.employeeNum = employeeNum;
      this.name = name;
    }

    public virtual string PrintDetails()
    {
      return employeeNum + " " + name;
    }
  }
}
