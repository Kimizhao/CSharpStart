using AutoMapper;
using Newtonsoft.Json;
using System;

namespace EmbeMapper
{
    /// <summary>
    /// 嵌套映射
    /// </summary>
    class Program
    {
        public class Employee
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }

            public Department Department { get; set; }
        }

        public class Department
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public string Heads { get; set; }
        }

        public class EmployeeDto
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public DepartmentDto Department { get; set; }
        }

        public class DepartmentDto
        {
            public int ID { get; set; }

            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDto>();
                cfg.CreateMap<Department, DepartmentDto>();
            });

            IMapper mapper = config.CreateMapper();

            var department = new Department
            {
                ID = 2,
                Name = "R & D",
                Heads = "JIAFIE"
            };

            var employee = new Employee
            {
                ID = 1,
                Name = "jon",
                Department = department,
                Age = 2
            };

            var dto = mapper.Map<Employee, EmployeeDto>(employee);
            Console.WriteLine(JsonConvert.SerializeObject(dto));
        }
    }
}
