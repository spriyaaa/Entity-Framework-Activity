using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActivityEF_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityEF_DTO;

namespace ActivityEF_DAL.Tests
{
    [TestClass()]
    public class Department_DALTests
    {
        Department_DAL dal = new Department_DAL();
       
        [TestMethod()]
        public void UpdateDepartmentTest()
        {
            DateTime date = DateTime.ParseExact("29/07/2021", "dd/MM/yyyy", null);
            Department_DTO obj = new Department_DTO { DepartmentID = 1, Name = "Engineering", GroupName = "Research and Development", ModifiedDate = date };
            int expected = 0;
            int actual = dal.UpdateDepartment(obj);
            Assert.AreEqual(expected, actual);
        }
    }
}