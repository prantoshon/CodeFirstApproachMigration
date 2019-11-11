using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using CodeFirstWebApp.Model.Model;

namespace CodeFirstWebApp.DatabaseContext.DatabaseContext
{
  public class  ProjectDbContext:DbContext
    {
        public DbSet<CategoryModel> CategorysDbSet { set; get; }
    }
}
