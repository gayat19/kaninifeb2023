using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingCollectionApp
{
    internal class Employee:IEquatable<Employee>,IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee()
        {
            
        }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return Id+" "+Name+" "+Salary; 
        }

        public bool Equals(Employee? other)
        {
            //Employee e1, e2;
            //e1 = this;
            //e2 = other;
            //if (e1.Id == e2.Id)
            //    return true;
            //return false;
            return this.Id == other.Id;
        }

        public int CompareTo(Employee? other)
        {
            return 0-this.Salary.CompareTo(other.Salary);
        }
        //public override bool Equals(object? obj)
        //{
        //    Employee e1, e2;
        //    e1 = this;
        //   e2 = obj as Employee;
        //    e2 = (Employee)obj;
        //    if (e1.Id == e2.Id)
        //        return true;
        //    return false;
        //}
    }
    class SortEmployeeByName : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
