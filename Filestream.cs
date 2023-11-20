using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Filestream
    {
        static void Main()
        {
            Filestream f = new Filestream("e\\b.txt",filemode.openorcreate);
            f.Writebyte(65);
            f.close();
        }

        static void Strem()
        {
            Filestream f = new Filestream();
            StreamWriter s = new StreamWriter(f);
            streamReader r = new streamReader(f);
            s.writeline("hello c#");
            s.close();
            f.close();
            Console.WriteLine("file created successfully");
        }
    }
}
