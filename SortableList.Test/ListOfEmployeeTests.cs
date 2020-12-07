using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortableList.Test
{

    /// <summary>
    ///This is a test class for ListOfEmployeeTest and is intended
    ///to contain all ListOfEmployeeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ListOfEmployeeTest
    {

        [TestMethod()]
        public void Count_EmptyList_ShouldReturn0()
        {
            EmployeeList listOfEmployee = new EmployeeList();
            Assert.AreEqual(0, listOfEmployee.Count);
        }

        [TestMethod()]
        public void Count_AddOne_ShouldReturnCount1()
        {
            EmployeeList listOfEmployee = new EmployeeList();
            HeadOfDepartment headOfDepartment = new HeadOfDepartment("Franz", "Abt1.", 7000);
            listOfEmployee.Insert(headOfDepartment);
            Assert.AreEqual(1, listOfEmployee.Count);
        }

        [TestMethod()]
        public void FindEmployeeByName_AddOne_ShouldReturnIndex0()
        {
            EmployeeList listOfEmployee = new EmployeeList();
            HeadOfDepartment headOfDepartment = new HeadOfDepartment("Franz", "Abt1.", 7000);
            listOfEmployee.Insert(headOfDepartment);
            int index = listOfEmployee.FindEmployeeByName("Franz");
            Assert.AreEqual(0, index);
            index = listOfEmployee.FindEmployeeByName("Fritz");
            Assert.AreEqual(-1, index);
        }

        [TestMethod()]
        public void FindEmployeeByName_NotFound_ShouldReturnIndexMinus1()
        {
            EmployeeList listOfEmployee = new EmployeeList();
            HeadOfDepartment headOfDepartment = new HeadOfDepartment("Franz", "Abt1.", 7000);
            listOfEmployee.Insert(headOfDepartment);
            int index = listOfEmployee.FindEmployeeByName("Fritz");
            Assert.AreEqual(-1, index);
        }

        [TestMethod()]
        public void FindEmployeeByName_AddMany_ShouldReturnCorrectIndices()
        {
            EmployeeList listOfEmployee = new EmployeeList();
            HeadOfDepartment headOfDepartment = new HeadOfDepartment("Franz", "Abt.1", 7000);
            Worker worker1 = new Worker("Hans", "Abt.1", 165, 12);  // 1980
            Worker worker2 = new Worker("Sepp", "Abt.1", 145, 20);  // 2900
            DepartmentalEmployee emp = new DepartmentalEmployee("Maria", "Abt.2", 1979);
            listOfEmployee.Insert(headOfDepartment);
            listOfEmployee.Insert(worker1);
            listOfEmployee.Insert(worker2);
            listOfEmployee.Insert(emp);
            int index = listOfEmployee.FindEmployeeByName("Franz");
            Assert.AreEqual(0, index);
            index = listOfEmployee.FindEmployeeByName("Fritz");
            Assert.AreEqual(-1, index);
            index = listOfEmployee.FindEmployeeByName("Maria");
            Assert.AreEqual(3, index);
            index = listOfEmployee.FindEmployeeByName("Hans");
            Assert.AreEqual(2, index);
            index = listOfEmployee.FindEmployeeByName("Sepp");
            Assert.AreEqual(1, index);
        }

        [TestMethod()]
        public void GetEmployees_AddMany_ShouldReturnArrayInCorrectOrder()
        {
            EmployeeList listOfEmployee = new EmployeeList();
            HeadOfDepartment headOfDepartment = new HeadOfDepartment("Franz", "Abt.1", 7000);
            Worker worker1 = new Worker("Hans", "Abt.1", 165, 12);
            Worker worker2 = new Worker("Sepp", "Abt.1", 145, 20);
            DepartmentalEmployee emp = new DepartmentalEmployee("Maria", "Abt.2", 1270);
            listOfEmployee.Insert(headOfDepartment);
            listOfEmployee.Insert(worker1);
            listOfEmployee.Insert(worker2);
            listOfEmployee.Insert(emp);
            Employee[] employees = listOfEmployee.GetEmployees();
            Assert.AreEqual(4, employees.Length, "Es gibt 4 Mitarbeiter");
            Assert.AreEqual("Franz", employees[0].Name, "Franz ist der Höchstverdiener");
            Assert.AreEqual("Maria", employees[3].Name, "Maria ist in der Liste hinten");
        }

        [TestMethod()]
        public void GetSalaryOfDepartment_AddMany_ShouldReturnCorrectSalary()
        {
            EmployeeList listOfEmployee = new EmployeeList();
            HeadOfDepartment headOfDepartment = new HeadOfDepartment("Franz", "Abt.1", 7000);
            Worker hans = new Worker("Hans", "Abt.1", 165, 12);
            Worker sepp = new Worker("Sepp", "Abt.1", 145, 20);
            DepartmentalEmployee maria = new DepartmentalEmployee("Maria", "Abt.2", 1270);
            listOfEmployee.Insert(headOfDepartment);
            listOfEmployee.Insert(hans);
            listOfEmployee.Insert(sepp);
            listOfEmployee.Insert(maria);
            double sumOfSalary = listOfEmployee.GetSalaryOfDepartment("Abt.1");
            Assert.AreEqual(7000 * 1.2 + 165 * 12 + 145 * 20, sumOfSalary);
            Assert.AreEqual(1270, listOfEmployee.GetSalaryOfDepartment("Abt.2"));
        }
        [TestMethod()]
        public void GetSalaryOfDepartment_EmptyDepartment_ShouldReturnSalary0()
        {
            EmployeeList listOfEmployee = new EmployeeList();
            Assert.AreEqual(0, listOfEmployee.GetSalaryOfDepartment("Abt.3"));
        }
    }
}
