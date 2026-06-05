using ToDo.Dto;
using ToDo.Repositoris;

namespace ToDo.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskrepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public List<TaskDto> SelectAll()
        {
            return _taskrepository.SelectAll();
        }
    }
}
