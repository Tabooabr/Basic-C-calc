using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Csharp__basica
{
    /// <summary>
    /// A type of operation the calculator can perform
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Adds two values together
        /// </summary>
        Add,
        /// <summary>
        /// Subtracts two values together
        /// </summary>
        Minus,
        /// <summary>
        /// Divides two values 
        /// </summary>
        Divide,
        /// <summary>
        /// Multiplies two values together
        /// </summary>
        Multiply
    }
}
