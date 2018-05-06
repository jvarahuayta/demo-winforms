using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dinjo.Base.Contracts.Repositories;
using Dinjo.Base.Contracts.Services;
using Dinjo.Base.Domain;
using Dinjo.Base.Infrastructure.Repositories;
using Dinjo.Base.Specifications;
using Dinjo.Logs.Contracts;
using Dinjo.Base.Exceptions;

namespace Dinjo.Base.Infrastructure.Services
{
    public abstract class BaseManager<T> : BaseService, IManager<T> where T : Entity
    {
        protected IRepository<T> repository;

        public BaseManager(IRepository<T> repository, ILogger iLogger) : base(iLogger)
        {
            this.repository = repository;
        }

        public virtual T Create(T entity)
        {
            //if (entity.CreatorId == null)
            //{
            //    throw new Exception("Creator_Id is required");
            //}

            try
            {
                return repository.Add(entity);
            }
            catch (Exception ex) when (!ex.GetType().IsSubclassOf(typeof(BaseRepository)))
            {
                logger.Exception(ex);

                throw new ServiceException();
            }
        }

        public virtual bool Deactivate(T entity)
        {
            //if (entity.ModifierId == null)
            //{
            //    throw new Exception("Modifier_Id is required");
            //}

            try
            {
                entity.Modified = DateTime.Now;

                entity.Active = 0;

                return repository.Update(entity) != null;
            }
            catch (Exception ex) when (!ex.GetType().IsSubclassOf(typeof(BaseRepository)))
            {
                logger.Exception(ex);

                throw new ServiceException();
            }
        }

        public virtual T GetById(int Id)
        {
            try
            {
                return repository.Get(new RecordByIdSpecification<T>(Id));
            }
            catch (Exception ex) when (!ex.GetType().IsSubclassOf(typeof(BaseRepository)))
            {
                logger.Exception(ex);

                throw new ServiceException();            }

        }

        public virtual List<T> GetAll()
        {
            try
            {
                return repository.GetList();
            }
            catch (Exception ex) when (!ex.GetType().IsSubclassOf(typeof(BaseRepository)))
            {
                logger.Exception(ex);

                throw new ServiceException();
            }

        }

        public virtual T Update(T entity)
        {
            //if (entity.ModifierId == null)
            //{
            //    throw new Exception("Modifier_Id is required");
            //}

            try
            {
                entity.Modified = DateTime.Now;

                return repository.Update(entity);
            }
            catch (Exception ex) when (!ex.GetType().IsSubclassOf(typeof(BaseRepository)))
            {
                logger.Exception(ex);

                throw new ServiceException();
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                entity.Modified = DateTime.Now;

                return repository.Delete(entity) != null;
            }
            catch (Exception ex) when (!ex.GetType().IsSubclassOf(typeof(BaseRepository)))
            {
                logger.Exception(ex);

                throw new ServiceException();
            }
        }
    }
}
