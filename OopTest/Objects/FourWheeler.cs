using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTest.Objects
{
    class FourWheeler:Vehicle, IInterior
    {
        public int NumberOfDoor { get; set; }
        public void DesignInterior()
        {

        }
    }

    interface IInterior
    {
        void DesignInterior();
    }

}
