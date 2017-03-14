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
            var companies = new List<Domain.Company>();
            using (JamsDBEntities db = new JamsDBEntities())
            {
                foreach (var company in db.Companies.ToList())
                {
                    companies.Add(new Domain.Company
                    {
                        CompanyId = company.CompanyId,
                        Name = company.Name,
                        Address = new Domain.Address
                        {
                            Street = company.Address,
                            Zip = company.Zip,
                            City = company.City
                        },
                        Reference = company.Reference,
                        Website = company.Website
                    });
                }
            }
            return companies;
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
                db.Companies.Add(new Models.Company
                {
                    Name = company.Name,
                    Address = company.Address.Street,
                    Zip = company.Address.Zip,
                    City = company.Address.City,
                    Reference = company.Reference,
                    Website = company.Website
                });
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
