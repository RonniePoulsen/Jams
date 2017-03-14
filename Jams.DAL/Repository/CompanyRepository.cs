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
            if (id == 0) return null;
            using(JamsDBEntities db = new JamsDBEntities())
            {
                var domainCompany = db.Companies.Where(c => c.CompanyId == id).Select(company => new Domain.Company
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
                }).FirstOrDefault();
                return domainCompany;
            }
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
            return true; // TODO: Maybe return the created CompanyId instead to use when creating a new Application and we need the CompanyId?! 
        }

        public bool UpdateCompany(Domain.Company updatedCompany)
        {
            if (updatedCompany == null) return false;
            
            using(JamsDBEntities db = new JamsDBEntities())
            {
                var dbCompany = db.Companies.Where(c => c.CompanyId == updatedCompany.CompanyId).FirstOrDefault();
                if (dbCompany == null) return false;

                dbCompany.Name = updatedCompany.Name;
                dbCompany.Address = updatedCompany.Address.Street;
                dbCompany.Zip = updatedCompany.Address.Zip;
                dbCompany.City = updatedCompany.Address.City;
                dbCompany.Reference = updatedCompany.Reference;
                dbCompany.Website = updatedCompany.Website;
                db.SaveChanges();
                return true;
            }
        }
    }
}
