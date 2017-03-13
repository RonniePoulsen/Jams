using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jams.DAL.Repository
{
    public interface IApplicationRepository
    {
        List<Domain.Application> GetAllApplications();
        Domain.Application GetApplication(int id);
        bool CreateApplication(Domain.Application application);
        bool UpdateApplication(Domain.Application application);
    }
}
