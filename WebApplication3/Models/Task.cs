using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace modelsTraining2.Models
{
    public class InvestmentContext : DbContext
    {
        public InvestmentContext() : base("DbConnection")
        {}
        public DbSet<Investment> ��������_�_��������� { get; set; }
    }
}