using CarStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.BL.Services
{
    public interface IOwnerService
    {
        IEnumerable<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        void CreateOwner(Owner owner);
    }
}