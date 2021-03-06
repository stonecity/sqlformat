using System;
using System.Collections.Generic;

namespace Laan.Sql.Parser.Entities
{
    public class DeclareStatement : CustomStatement
    {
        /// <summary>
        /// Initializes a new instance of the DeclareStatement class.
        /// </summary>
        public DeclareStatement()
        {
            Definitions = new List<VariableDefinition>();
        }

        public List<VariableDefinition> Definitions { get; set; }
    }
}
