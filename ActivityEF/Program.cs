using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityEF_BL;
using ActivityEF_DTO;

namespace ActivityEF
{
    class Program
    {
        static void Main(string[] args)
        {
            try {

                Department_DTO dto = new Department_DTO();
                Department_BL dbl = new Department_BL();

                Console.WriteLine("Enter the Department Id to be updated: ");
                short deptId = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter Name: ");
                string Name = Console.ReadLine();

                Console.WriteLine("Enter Group Name: ");
                string GroupName = Console.ReadLine();

                Console.WriteLine("Date(dd/m/yyyy HH:mm:ss) : ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                dto = dbl.DepartmentInputValues(deptId, Name, GroupName, date);
                int status = dbl.UpdateDepartmentInfo(dto);
                if (status == 1)
                {
                    Console.WriteLine("Updated Successfully! Check below ");
                    Console.WriteLine("-------------------------------------------------------------");
                    foreach (var item in dbl.DisplayDepartment())
                    {
                        Console.WriteLine($"{item.DepartmentID}  {item.Name}  {item.GroupName}  {item.ModifiedDate}");
                    }
                }

                Console.WriteLine("Do you want to delete any records? (y/n)");
                if(Console.ReadLine()=="y")
                {
                    Console.WriteLine("Enter the Department Id to be deleted: ");
                    short deletedeptId = Convert.ToInt16(Console.ReadLine());
                    int st=dbl.deleteDepartmentInfo(deletedeptId);
                    if(st==1)
                    {
                        Console.WriteLine("Deleted Successfully! Check below");
                        Console.WriteLine("-------------------------------------------------------------");
                        foreach (var item in dbl.DisplayDepartment())
                        {
                            Console.WriteLine($"{item.DepartmentID}  {item.Name}  {item.GroupName}  {item.ModifiedDate}");
                        }
                    }
                }

                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid Input");
                throw ex;
            }
            }
    }
}
