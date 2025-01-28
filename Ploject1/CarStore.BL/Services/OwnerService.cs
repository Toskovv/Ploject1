using CarStore.DL.Repositories;
using CarStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.BL.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _ownerRepository;

        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public IEnumerable<Owner> GetAllOwners() => _ownerRepository.GetAllOwners();

        public Owner GetOwnerById(int id) => _ownerRepository.GetOwnerById(id);

        public void CreateOwner(Owner owner)
        {
            if (string.IsNullOrWhiteSpace(owner.Name))
                throw new ArgumentException("Owner name is required");

            _ownerRepository.AddOwner(owner);
        }
    }
}
