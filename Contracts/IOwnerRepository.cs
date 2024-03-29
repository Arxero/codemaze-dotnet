﻿using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IOwnerRepository : IRepositoryBase<Owner>
    {
        IEnumerable<Owner> GetAllOwners();
        Owner GetOwnerById(int ownerId);
        OwnerDTO GetOwnerWithDetails(int ownerid);
    }
}
