using System;
using System.Collections.Generic;
using Torshia.Models;

namespace Torshia.App.Services.Contracts
{
    public interface ITasksService
    {
        Task GetById(int id);

        void Register(string title, DateTime dueDate, string description, string participants, List<string> affectedSectors);

        List<Task> GetAll();
    }
}