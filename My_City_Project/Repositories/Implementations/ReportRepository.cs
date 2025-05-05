using My_City_Project.Data;
using My_City_Project.Model.Entities;
using My_City_Project.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace My_City_Project.Repositories.Implementations
{
    public class ReportRepository : IReportRepository
    {
        private readonly ApplicationContext _context;

        public ReportRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Report> GetAllReports()
        {
            return _context.Reports.ToList();
        }

        public Report GetReportById(Guid id)
        {
            return _context.Reports.Find(id);
        }

        public void AddReport(Report report)
        {
            _context.Reports.Add(report);
            _context.SaveChanges();
        }

        public void UpdateReport(Report report)
        {
            _context.Reports.Update(report);
            _context.SaveChanges();
        }

        public void DeleteReport(Guid id)
        {
            var report = _context.Reports.Find(id);
            if (report != null)
            {
                _context.Reports.Remove(report);
                _context.SaveChanges();
            }
        }
    }
}
