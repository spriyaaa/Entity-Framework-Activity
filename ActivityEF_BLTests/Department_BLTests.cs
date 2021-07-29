using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActivityEF_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityEF_DTO;

namespace ActivityEF_BL.Tests
{
    [TestClass()]
    public class Department_BLTests
    {
        [TestMethod()]
        public void PDepartmentInputValuesTest()
        {
            DateTime date = DateTime.ParseExact("29/07/2021", "dd/MM/yyyy", null);
            Department_DTO obj = new Department_DTO { DepartmentID = 1, Name = "Engineering", GroupName = "Research and Development", ModifiedDate = date };

            Department_BL dbl = new Department_BL();
            var expected = obj.Name;
            var actual= dbl.DepartmentInputValues(1, "Engineering", "Research and Development", date).Name;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NDepartmentInputValuesTest()
        {
            DateTime date = DateTime.ParseExact("29/07/2021", "dd/MM/yyyy", null);
            Department_DTO obj = new Department_DTO { DepartmentID = 1, Name = "Engineering", GroupName = "Research and Development", ModifiedDate = date };

            Department_BL dbl = new Department_BL();
            var expected = obj.Name;
            var actual = dbl.DepartmentInputValues(1, "Human Resource", "Research and Development", date).Name;
            Assert.AreNotEqual(expected, actual);
        }
    }
}