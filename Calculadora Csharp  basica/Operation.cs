using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Csharp__basica
{
    /// <summary>
    /// Holds info about a single calculator operation
    /// </summary>
    public class Operation
    {
        #region Public properties

        /// <summary>
        /// The left side of the opetation
        /// </summary>

        public string Leftside { get; set; }
        
        /// <summary>
        /// The right side of the operation
        /// </summary>

        public string Rightside { get; set; }
        
        /// <summary>
        /// The trype of operation to perform
        /// </summary>

        public OperationType operationType{get; set;}
        
        /// <summary>
        /// The inner operation to be performed initially before this operation
        /// </summary>

        public Operation InnerOperation { get; set; }

        #endregion

        #region constructor
        /// <summary>
        /// Simple constructor :)
        /// </summary>
        public Operation()
        {
            //create empty strings instead of having nulls
            this.Leftside = string.Empty;
            this.Rightside = string.Empty;
        }
        #endregion
    }
}
