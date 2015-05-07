using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterlessProperties
{
    /// <summary>
    /// this class has no data encapsulation you should not implement an
    /// object this way with direct access to your fields
    /// </summary>
    class BadPerson
    {
        public string Name;
        public Int32 Age;
    }
}
