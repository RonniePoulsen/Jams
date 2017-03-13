using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jams;
using Jams.DAL.Models;

namespace Jams.DAL.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        public List<Domain.Company> GetAllCompanies()
        {
            throw new NotImplementedException();
        }

        public Domain.Company GetCompany(int id)
        {
            throw new NotImplementedException();
        }

        public bool CreateCompany(Domain.Company company)
        {
            if (company == null) return false;
            using(JamsDBEntities db = new JamsDBEntities())
            {
                var newAddress = new Models.Address
                {
                    Street = company.Address.Street,
                    StreetNumber = company.Address.StreetNumber,
                    Zip = company.Address.Zip,
                    City = company.Address.City
                };
                db.Addresses.Add(newAddress);
                db.SaveChanges();
                var newCompany = new Models.Company
                {
                    Name = company.Name,
                    AddressId = newAddress.AddressId, // AddressId is returned after Address object is saved to DB.
                    Website = company.Website
                };
                db.Companies.Add(newCompany);
                db.SaveChanges();
            }

            return true;
        }

        public bool UpdateCompany(Domain.Company company)
        {
            throw new NotImplementedException();
        }
    }
}
