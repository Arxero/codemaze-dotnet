using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Owner> GetAllOwners()
        {
            return FindAll().OrderBy(o => o.Name).ToList();
        }

        public Owner GetOwnerById(int ownerId)
        {
            return FindByCondition(o => o.Id == ownerId).FirstOrDefault();
        }

        public OwnerDTO GetOwnerWithDetails(int ownerid)
        {
            return new OwnerDTO(GetOwnerById(ownerid));
        }
    }
}
