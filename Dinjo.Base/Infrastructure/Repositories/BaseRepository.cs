using Dinjo.Logs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinjo.Base.Infrastructure.Repositories
{
    public abstract class BaseRepository
    {
        protected ILogger logger;

        public BaseRepository(ILogger iLogger)
        {
            this.logger = iLogger;
            logger.SetCaller(this);
        }
    }
}
