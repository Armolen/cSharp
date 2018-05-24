using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenWeb.Controllers;

namespace BenWeb.Models.Interfaces
{
    public interface IOwnerRepository
    {
        int AddOwner(Owner owner);
        Owner GetOwner(int ownerId);
    }
}
