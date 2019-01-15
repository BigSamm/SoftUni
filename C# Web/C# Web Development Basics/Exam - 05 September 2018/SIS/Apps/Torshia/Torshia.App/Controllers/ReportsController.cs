using SIS.Framework.ActionResults;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Torshia.App.Controllers.Base;
using Torshia.App.Services.Contracts;
using Torshia.App.ViewModels.Reports;
using Torshia.Models;

namespace Torshia.App.Controllers
{
    public class ReportsController : BaseController
    {
        private readonly IReportsService reportsService;

        public ReportsController(IReportsService reportsService)
        {
            this.reportsService = reportsService;
        }

        public IActionResult All()
        {
            List<Report> reports = this.reportsService.GetAll();

            int index = 1;
            List<ReportAllViewModel> reportViewModels = reports.Select(x => new ReportAllViewModel
            {
                Index = index++,
                TaskId = x.Task.Id,
                TaskLevel = x.Task.Level,
                TaskTitle = x.Task.Title,
                TaskStatus = x.Status.ToString(),
            }).ToList();

            base.Model["Reports"] = reportViewModels;

            return base.View();
        }

        public IActionResult Details(int id)
        {
            Report report = this.reportsService.GetById(id);

            if (report == null)
                return base.RedirectToAction("/");

            var viewModel = new ReportDetailsViewModel
            {
                AffectedSectors = String.Join(", ", report.Task.AffectedSectors.Select(x => x.Sector.ToString())),
                DueDate = report.Task.DueDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                Id = report.Id,
                Participants = String.Join(", ", report.Task.Participants.Select(x => x.Content)),
                ReportedOn = report.ReportedOn.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                Reporter = report.Reporter.Username,
                Status = report.Status.ToString(),
                Task = report.Task.Title,
                Description = report.Task.Description,
                Level = report.Task.Level,
            };

            base.Model["Report"] = viewModel;

            return base.View();
        }
    }
}