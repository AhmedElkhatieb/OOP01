using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // What can we write inside namespace?
    // Class
    // Strucr
    // Interface
    // Enum

    // Allowed access modifiers inside namespace
    // internal (default)
    // public
    public class TypeA
    {
        #region Definitions
        // What can we write inside class or struct?
        // attribute (field or variable)
        // property (full property - automatic property - indexer)
        // functions (constructor - getter/setter - method)
        // Event

        // Allowed access modifiers inside struct
        // private
        // internal
        // public

        // Allowed access modifiers inside class
        // private
        // private protected
        // protected
        // internal
        // internal protected
        // public

        // private => بيتشاف في حدود الكلاس او ال ستراكب فقط
        // internal => بينشاف في حدود ال بروجكت فقط
        // public => بيتشاف في كل حتة
        
        // What can we write inside the interface
        // Signature for property
        // Signature for method
        // default implemnted method

        //default access modifier inside interface is public
        #endregion
        /*private*/ int X;
        internal int Y;
        public int Z;
    }

}
