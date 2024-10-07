using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data;
using TodoSeverApp.Data.Interfaces;

namespace TodoSeverApp.Data.Migrations.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            return await context.TaskItems.ToArrayAsync();
        }
    }
}