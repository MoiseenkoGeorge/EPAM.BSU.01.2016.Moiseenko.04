using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public enum Sex { Male = 1, Female = 2  }

    public interface IPerson
    {
        string Name { get; }
        DateTime Birthday { get; }
        Sex Sex { get; }
    }
}
