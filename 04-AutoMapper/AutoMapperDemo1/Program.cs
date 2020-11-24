using AutoMapper;
using System;

namespace AutoMapperDemo1
{
    /// <summary>
    /// 参考：
    /// 官方手册：https://docs.automapper.org/en/latest/Getting-started.html
    /// 【C#】AutoMapper 使用手册 https://juejin.cn/post/6844904187164098573
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Foo, FooDto>());

            var mapper = config.CreateMapper();

            Foo foo = new Foo { ID = 1, Name = "Tom" };

            FooDto dto = mapper.Map<FooDto>(foo);
            Console.WriteLine($"{dto.ID} {dto.Name}");
        }
    }
}
