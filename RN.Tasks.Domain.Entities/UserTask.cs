using System;
using System.ComponentModel.DataAnnotations.Schema;
using RN.Tasks.Domain.Entities.Base;

namespace RN.Tasks.Domain.Entities
{
    public class UserTask : DataEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Performer { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime FinishedDate { get; set; }
        
        public long PlannedComplexity { get; set; }
        
        public long LeadTime { get; set; }
        
        public int? TaskId { get; set; }
        
        [NotMapped]
        [ForeignKey("TaskId")]
        public virtual UserTask ParentTask { get; set; }
    }
}