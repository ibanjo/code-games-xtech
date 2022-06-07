using NUnit.Framework.Internal.Execution;
using Research.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Repository.IRepository
{
    public interface IEventRepository : IGenericRepository<Event, Guid>
    {

    }
}
