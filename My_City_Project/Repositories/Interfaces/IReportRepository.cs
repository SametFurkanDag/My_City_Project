using My_City_Project.Model.Entities;
using System.Collections.Generic;

namespace My_City_Project.Repositories.Interfaces
{
    public interface IReportRepository
    {
        List<Report> GetAllReports();
        Report GetReportById(Guid id);
        void AddReport(Report report);
        void UpdateReport(Report report);
        void DeleteReport(Guid id);
    }
}
