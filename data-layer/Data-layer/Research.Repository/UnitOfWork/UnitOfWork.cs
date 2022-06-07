using NUnit.Framework.Internal.Execution;
using Research.Domain.Context;
using Research.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork<ResearchContext>, IDisposable
    {
        private readonly ResearchContext _context;
        private bool disposed = false;
        private IGenericRepository<Event, Guid> _eventRepository;

        public IGenericRepository<Event, Guid> EventRepository
        {
            get
            {
                return _eventRepository ?? (_eventRepository = new GenericRepository<Event, Guid>(_context));
            }
        }

        public UnitOfWork(ResearchContext context)
        {
            _context = context;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
