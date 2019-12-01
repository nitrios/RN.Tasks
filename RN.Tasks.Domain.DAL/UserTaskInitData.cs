using System;
using RN.Tasks.Domain.Entities;

namespace RN.Tasks.Domain.DAL
{
    public static class UserTaskInitData
    {
        public static UserTask[] Get()
        {
            return new UserTask[]
            {
                new UserTask()
                {
                    Id = 1,
                    CreationDate = DateTime.Now,
                    Description = "First task description",
                    FinishedDate = DateTime.MinValue,
                    LeadTime = 0,
                    Name = "First task",
                    Performer = "All",
                    PlannedComplexity = 100,
                    TaskId = null
                }, 
                
                new UserTask()
                {
                    Id = 2,
                    CreationDate = DateTime.Now,
                    Description = "Second sub task description",
                    FinishedDate = DateTime.MinValue,
                    LeadTime = 0,
                    Name = "Second task",
                    Performer = "User",
                    PlannedComplexity = 140,
                    TaskId = 1
                }, 
                
                new UserTask()
                {
                    Id = 3,
                    CreationDate = DateTime.Now,
                    Description = "Third task description",
                    FinishedDate = DateTime.MinValue,
                    LeadTime = 0,
                    Name = "Third task",
                    Performer = "Admin",
                    PlannedComplexity = 999,
                    TaskId = null
                }
                
            };
        }
    }
}