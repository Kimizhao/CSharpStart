using AutoMapper;
using Newtonsoft.Json;
using System;

namespace PolymMapper
{
    class Program
    {
        public class Employee
        {
            public int ID { get; set; }

            public string Name { get; set; }
        }

        public class Employee2 : Employee
        {
            public string DeptName { get; set; }
        }

        public class EmployeeDto
        {
            public int ID { get; set; }

            public string Name { get; set; }
        }

        public class EmployeeDto2 : EmployeeDto
        {
            public string DeptName { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDto>().Include<Employee2, EmployeeDto2>();
                //cfg.CreateMap<Employee, EmployeeDto>();
                cfg.CreateMap<Employee2, EmployeeDto2>();
            });
            IMapper mapper = config.CreateMapper();

            var employees = new[]
            {
                new Employee { ID = 1, Name = "Tom" },
                new Employee2 { ID = 2, Name = "Jerry", DeptName = "R & D" }
            };

            var dto = mapper.Map<Employee[], EmployeeDto[]>(employees);
            Console.WriteLine(JsonConvert.SerializeObject(dto));
        }
    }
}
