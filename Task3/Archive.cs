using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public sealed class Archive
    {
        private List<Mark> markList;
        public static readonly Lazy<Archive> instance =
            new Lazy<Archive>(() => new Archive());
        public static Archive Instance { get { return instance.Value;} } 
        private Archive()
        {
            markList = new List<Mark>();
        }
        public void AddMark(Mark mark)
        {
            instance.Value.markList.Add(mark);
        }
    }
}
