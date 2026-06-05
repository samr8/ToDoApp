using ToDo.Dto;

namespace ToDo.Repositoris
{
    public interface ITaskRepository
    {
        List<TaskDto> SelectAll();
        TaskDto GetTaskById(int TaskId);
        bool UpsertTask(TaskDto task);
        bool DeleteTask(int TaskId);

    }
}
