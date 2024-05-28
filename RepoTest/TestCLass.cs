using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoTest.RepoTest
{
    public class TestCLass
    {
        private int _id = 1;
        public void Caller()
        {
            _id++;
            Console.WriteLine(_id);
        }
    }
}
