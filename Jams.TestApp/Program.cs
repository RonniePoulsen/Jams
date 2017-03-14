using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jams.DAL.Repository;

namespace Jams.TestApp
{
    public class Program
    {

        static void Main(string[] args)
        {
            ICompanyRepository _companyRepository = new CompanyRepository();

            var updatedCompany = new Domain.Company
            {
                CompanyId = 3,
                Name = "VISMA Insulting",
                Address = new Domain.Address
                {
                    Street = "Nøregaaaaardsvej 32",
                    Zip = 2860,
                    City = "Søborg"
                },
                Reference = "Hansen Sabrina",
                Website = "www.facebook.dk"
            };
            _companyRepository.UpdateCompany(updatedCompany);
            //var companies = _companyRepository.GetAllCompanies();
            //var company = _companyRepository.GetCompany(3); 
            //CreateCompany();
        }

        private static void CreateCompany()
        {
            ICompanyRepository _companyRepository = new CompanyRepository();

            var company = new Domain.Company
            {
                Name = "Kraftvaerk A/S",
                Address = new Domain.Address
                {
                    Street = "NJALSGADE 21G, 5. SAL",
                    Zip = 2300,
                    City = "København S"
                },
                Reference = "Rostislav Semenov",
                Website = "www.kraftvaerk.dk"
            };
            if (_companyRepository.CreateCompany(company))
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("NO success");
            }
        }
    }
}
