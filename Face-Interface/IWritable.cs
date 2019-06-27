using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Interface
{
    public interface IWritable
    {
        void Write(TextWriter writer);
    }
}
