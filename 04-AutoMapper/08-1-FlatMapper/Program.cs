using AutoMapper;
using Newtonsoft.Json;
using System;

namespace _08_1_FlatMapper
{
    /// <summary>
    /// 扁平化映射
    /// </summary>
    class Program
    {
        public class Employee
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public Department Department { get; set; }
        }

        public class Department
        {
            public int ID { get; set; }

            public string Name { get; set; }
        }

        public class EmployeeDto
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public int DepartmentID { get; set; }

            public string DepartmentName { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDto>();
                cfg.CreateMap<Department, EmployeeDto>();
            });

            IMapper mapper = config.CreateMapper();
            var employee = new Employee 
            { 
                ID = 1,
                Name = "jon",
                Department = new Department
                {
                    ID = 2,
                    Name = "R & D"
                }
            };

            var dto = mapper.Map<Employee, EmployeeDto>(employee);
            Console.WriteLine(JsonConvert.SerializeObject(dto));
        }
    }
}
