using AutoMapper;
using Newtonsoft.Json;
using System;

namespace _07_CustomMapper
{
    //当源类型与目标类型名称不一致时，或者需要对源数据做一些转换时，可以用自定义映射。
    class Program
    {
        public class Employee
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public DateTime JoinTime { get; set; }
        }

        public class EmployeeDto
        {
            public int EmployeeID { get; set; }

            public string EmployeeName { get; set; }

            public int JoinYear { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDto>()
                    .ForMember("EmployeeID", opt => opt.MapFrom(src => src.ID))
                    .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.JoinYear, opt => opt.MapFrom(src => src.JoinTime.Year));
            });

            IMapper mapper = config.CreateMapper();

            var employee = new Employee { ID = 1, Name = "Kimi", JoinTime = DateTime.Now };

            var dto = mapper.Map<Employee, EmployeeDto>(employee);
            Console.WriteLine(JsonConvert.SerializeObject(dto));

        }
    }
}
