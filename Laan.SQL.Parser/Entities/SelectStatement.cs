using System;
using System.Collections.Generic;

using Laan.SQL.Parser.Expressions;

namespace Laan.SQL.Parser
{

    public class SelectStatement : CustomStatement
    {
        public SelectStatement() : base()
        {
            Distinct = false;
            Top = null;
            OrderBy = new List<Field>();
            GroupBy = new List<Field>();
        }

        public bool Distinct { get; set; }
        public int? Top { get; set; }
        public List<Field> OrderBy { get; set; }
        public List<Field> GroupBy { get; set; }
        public Expression Having { get; set; }
    }
}