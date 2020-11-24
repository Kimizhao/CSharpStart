using AutoMapper;
using System;

namespace NamingConvention
{
    class Program
    {
        //默认情况下，AutoMapper 基于相同的字段名映射，并且是 不区分大小写 的。
        //但有时，我们需要处理一些特殊的情况。
        //SourceMemberNamingConvention 表示源类型命名规则
        //DestinationMemberNamingConvention 表示目标类型命名规则
        //LowerUnderscoreNamingConvention 和 PascalCaseNamingConvention 是 AutoMapper 提供的两个命名规则。前者命名是小写并包含下划线，后者就是帕斯卡命名规则（每个单词的首字母大写）。
        //我的理解，如果源类型和目标类型分别采用了 蛇形命名法 和 驼峰命名法，那么就需要指定命名规则，使其能正确映射。
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Foo, FooDto>();

                cfg.SourceMemberNamingConvention = new PascalCaseNamingConvention();
                cfg.DestinationMemberNamingConvention = new LowerUnderscoreNamingConvention();
            });

            var mapper = config.CreateMapper();

            Foo foo = new Foo { Id = 2, MyName = "Tom" };

            FooDto dto = mapper.Map<FooDto>(foo);
            Console.WriteLine($"{dto.ID} {dto.My_Name}");

        }
    }
}
