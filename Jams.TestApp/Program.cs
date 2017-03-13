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

            var company = new Domain.Company
            {
                Name = "Capgemini Sogeti Danmark",
                Address = new Domain.Address
                {
                    Street = "Delta Park",
                    StreetNumber = 40,
                    Zip = 2665,
                    City = "Vallensbæk Strand"
                },
                Website = "www.capgeminisogeti.dk"
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
