using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jams.Domain
{
    public class Application
    {
        public int ApplicationId { get; set; }
        public Company Company { get; set; }
        public Motivation Motivation { get; set; }
        public DateTime DateSent { get; set; }
        public DateTime DateUpdated { get; set; }
        public Status Status { get; set; }
        public string Comment { get; set; }
    }

    public enum Motivation
    {
        Unsolicited,
        Advertised,
        Network,
        HeadHunted
    }

    public enum Status
    {
        ApplicationSent,
        ApplicationConfirmed,
        Invited,
        Interviewed,
        Rejected,
        Hired
    }
}
