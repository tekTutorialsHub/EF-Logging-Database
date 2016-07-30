using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EntityFramework
{


    public class Employee
    {

        public int EmployeeID { get; set; }

        public string Name { get; set; }

        //Navigation property Returns the Employee Address
        public virtual EmployeeAddress EmployeeAddress { get; set; }

        //Navigation property Returns the Employee Department
        public virtual Department Department { get; set; }


        //Navigational Property for Grade
        public virtual Grade Grade { get; set; }
        //GradeID is defined here. EF will mark this as ForeignKey
        public int GradeID { get; set; }

        //Navigation property
        public virtual ICollection<Project> Projects { get; set; }
    }

    public class EmployeeAddress
    {

        //Defining the ForeignKey 
        [Key, ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        //Navigation property Returns the Employee object
        public virtual Employee Employee { get; set; }

    }


    public class Department
    {

        public int DepartmentID { get; set; }
        public string Name { get; set; }

        //Navigational Property. Returns the collection of employee
        public virtual ICollection<Employee> Employees { get; set; }

    }




    public class Grade
    {

        public int GradeID { get; set; }
        public string Name { get; set; }

        //Navigation property
        public virtual ICollection<Employee> Employees { get; set; }

    }


    public class Project
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }

        //Navigation property
        public virtual ICollection<Employee> Employees { get; set; }
    }

}
