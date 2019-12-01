using System;
using System.Data;

namespace RN.Tasks.Domain.Entities
{
    public class UserTask
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Performer { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime FinishedDate { get; set; }
        
        public long PlannedComplexity { get; set; }
        
        public long LeadTime { get; set; }
    }
}