using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext repoContext;
        private IOwnerRepository owner;


        public IOwnerRepository Owner
        {
            get
            {
                if (owner == null)
                {
                    owner = new OwnerRepository(repoContext);
                }

                return owner;
            }
        }


        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            repoContext = repositoryContext;
        }

        public void Save()
        {
            repoContext.SaveChanges();
        }
    }
}
