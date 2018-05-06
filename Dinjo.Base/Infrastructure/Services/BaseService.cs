using Dinjo.Logs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinjo.Base.Infrastructure.Services
{
    public abstract class BaseService
    {
        protected ILogger logger;

        public BaseService(ILogger iLogger)
        {
            this.logger = iLogger;
            logger.SetCaller(this);
        }

        public ILogger ILogger
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
