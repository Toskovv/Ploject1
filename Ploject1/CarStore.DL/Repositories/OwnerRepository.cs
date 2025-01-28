using CarStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.DL.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly List<Owner> _owners = new();

        public IEnumerable<Owner> GetAllOwners() => _owners;

        public Owner GetOwnerById(int id) => _owners.FirstOrDefault(o => o.Id == id);

        public void AddOwner(Owner owner)
        {
            owner.Id = _owners.Count + 1;
            _owners.Add(owner);
        }

        public void UpdateOwner(Owner owner)
        {
            var existingOwner = GetOwnerById(owner.Id);
            if (existingOwner != null)
            {
                existingOwner.Name = owner.Name;
                existingOwner.Email = owner.Email;
                existingOwner.CarIds = owner.CarIds;
            }
        }

        public void DeleteOwner(int id)
        {
            var owner = GetOwnerById(id);
            if (owner != null) _owners.Remove(owner);
        }
    }
}