using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jams.DAL.Repository
{
    public interface ICompanyRepository
    {
        List<Domain.Company> GetAllCompanies();
        Domain.Company GetCompany(int id);
        bool CreateCompany(Domain.Company company);
        bool UpdateCompany(Domain.Company company);
    }
}
