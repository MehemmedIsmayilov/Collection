using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{

    class Calculator Calculator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
    }
}
