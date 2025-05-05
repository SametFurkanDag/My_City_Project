using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Services.Interfaces
{
    public interface IReportService
    {
        List<Report> GetAllReports();
        Report GetReportById(Guid id);
        void CreateReport(Report report);
        void DeleteReport(Guid id);
        void UpdateReport(Report report);
    }
}
