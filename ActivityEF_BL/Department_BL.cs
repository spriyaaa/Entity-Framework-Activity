using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityEF_DAL;
using ActivityEF_DTO;
namespace ActivityEF_BL
{
    public class Department_BL
    {
        Department_DAL dal = new Department_DAL();



        public Department_DTO DepartmentInputValues(short deptId, string Name, string groupName, DateTime modifiedDate)
        {
            try
            {
                Department_DTO obj = new Department_DTO();
                obj.DepartmentID = deptId;
                obj.Name = Name;
                obj.GroupName = groupName;
                obj.ModifiedDate = modifiedDate;

                return obj;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateDepartmentInfo(Department_DTO newObj)
        {
            int result = dal.UpdateDepartment(newObj);
            return result;
        }

        public int deleteDepartmentInfo(short departmentId)
        {
            int result = dal.deleteDepartment(departmentId);
            return result;
        }

        public List<Department_DTO> DisplayDepartment()
        {
            try
            {
                List<Department_DTO> depts = new List<Department_DTO>();

                foreach (var item in dal.DisplayDepartment())
                {
                    Department_DTO dto = new Department_DTO
                    {
                        DepartmentID = item.DepartmentID,
                        Name = item.Name,
                        GroupName = item.GroupName,
                        ModifiedDate = item.ModifiedDate
                    };
                    depts.Add(dto);
                }
                return depts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

