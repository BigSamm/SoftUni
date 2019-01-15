using System;
using System.Collections.Generic;
using System.Linq;
using Torshia.App.Services.Contracts;
using Torshia.Data;
using Torshia.Models;
using Torshia.Models.Enums;

namespace Torshia.App.Services
{
    public class TasksService : ITasksService
    {
        private readonly TorshiaDbContext dbContext;

        public TasksService(TorshiaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task GetById(int id)
        {
            return this.dbContext.Tasks.FirstOrDefault(x => x.Id == id);
        }

        public void Register(string title, DateTime dueDate, string description, string participants, List<string> affectedSectors)
        {
            List<Participant> dbParticipants = participants
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => new Participant { Content = x }).ToList();

            var task = new Task
            {
                Description = description,
                DueDate = dueDate,
                Title = title,
                Participants = dbParticipants,
            };

            var dbAffectedSectors = new List<TaskSector>();
            foreach (var sectorName in affectedSectors)
            {
                if (!Enum.TryParse(sectorName, out SectorType sectorType))
                    continue;
                
                var taskSector = new TaskSector
                {
                    Sector = sectorType,
                };
                dbAffectedSectors.Add(taskSector);
            }

            task.AffectedSectors = dbAffectedSectors;

            this.dbContext.Tasks.Add(task);
            this.dbContext.SaveChanges();
        }

        public List<Task> GetAll()
        {
            return this.dbContext.Tasks.ToList();
        }
    }
}