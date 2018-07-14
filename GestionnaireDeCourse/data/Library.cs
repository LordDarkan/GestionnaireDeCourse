using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireDeCourse.data
{
    public class Library
    {
        public static IMapper GetNewMapper() => new MapperMock();
        //public static IMapper GetNewMapper() => new Mapper();
    }
}
