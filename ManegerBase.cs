using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerProject
{
    public class ManagerBase
    {
        public Manager Manager { get; }

        public ManagerBase(Manager manager)
        {
            Manager = manager;
        }
    }
}
