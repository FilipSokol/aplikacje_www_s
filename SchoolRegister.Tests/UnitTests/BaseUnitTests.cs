using SchoolRegister.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister.Tests.UnitTests
{
    public abstract class BaseUnitTests
    {
        protected readonly ApplicationDbContext _dbContext;

        public BaseUnitTests (ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
