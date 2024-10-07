using TodoServerApp.Data;

namespace TodoSeverApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItem>> GetTaskItemsAsync();
    }
}