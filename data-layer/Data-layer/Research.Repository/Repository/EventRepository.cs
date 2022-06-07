using NUnit.Framework.Internal.Execution;
using Research.Domain.Context;
using Research.GenericRepository;
using Research.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Repository.Repository
{
    public class EventRepository : GenericRepository<Event, Guid>, IEventRepository
    {
        public EventRepository(ResearchContext context) : base(context)
        {

        }
    }
}
