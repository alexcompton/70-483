using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterlessProperties
{
    /// <summary>
    /// this is a superior implementation of person over the "BadPerson"
    /// you want to make sure you take advantage of data encapsulation
    /// and protection your fields by using properties
    /// </summary>
    class GoodPerson
    {
        // if all you are trying to do is encapsulate a backing field this
        // is convient syntax for that
        public String Name { get; set; }
        
        // other wise this is the long way to create a property
        private Int32 m_Age;

        public Int32 Age
        {
            get { return (m_Age); }
            set
            {
                // dont let someone create a person with a negative age
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", value.ToString(), "value must be greater than 0");
                }

                m_Age = value;
            }
        }
    }
}
