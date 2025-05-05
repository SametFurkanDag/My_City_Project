using My_City_Project.Model.Entities;
using My_City_Project.Repositories.Interfaces;
using My_City_Project.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace My_City_Project.Services.Implementations
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _reportRepository;

        public ReportService(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public List<Report> GetAllReports()
        {
           
            return _reportRepository.GetAllReports().ToList();
        }

        public Report GetReportById(Guid id)
        {
           
            return _reportRepository.GetReportById(id);
        }

        public void CreateReport(Report report)
        {
         
            _reportRepository.AddReport(report);
        }

        public void DeleteReport(Guid id)
        {
           _reportRepository.DeleteReport(id);
        }

        public void UpdateReport(Report report)
        {
            
            _reportRepository.UpdateReport(report);
        }
    }
}
