using AutoMapper;
using System;
using System.Collections.Generic;

namespace ArrayListMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Source, Destination>();
            });

            IMapper mapper = config.CreateMapper();

            var sources = new[]
            {
                new Source{Value = 5},
                new Source{Value = 6},
                new Source{Value = 7}
            };

            IEnumerable<Destination> ienumerableDest = mapper.Map<Source[], IEnumerable<Destination>>(sources);
            ICollection<Destination> icollectionDest = mapper.Map<Source[], ICollection<Destination>>(sources);
            IList<Destination> ilistDest = mapper.Map<Source[], IList<Destination>>(sources);
            List<Destination> listDest = mapper.Map<Source[], List<Destination>>(sources);
            Destination[] arrayDest = mapper.Map<Source[], Destination[]>(sources);

        }
    }
}
