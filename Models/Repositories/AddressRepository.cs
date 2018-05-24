using BenWeb.Models.Database;
using BenWeb.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BenWeb.Models.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly DatabaseContext _databaseContext;

        public AddressRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public int AddAddress(Address address)
        {
           if (address == null)
            {
                throw new Exception("Address Object cannot be null");
            }

            _databaseContext.Addresses.Add(address);
            _databaseContext.SaveChanges();
            return address.AddressId;
        }

        public Address GetAddress(int addressId)
        {
            if (addressId <= 0) 
            {
                throw new Exception("AddressId cannot be less than 1");
            }

            return _databaseContext.Addresses.FirstOrDefault(address => address.AddressId == addressId);
        }
    }
}
