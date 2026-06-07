using ToDo.Dto;

namespace ToDo.Repositoris
{
    public interface ITaskRepository
    {
        List<TaskDto> SelectAll();
        bool TaskUpsert(TaskDto task);
        bool TaskDelete(int taskid);
         TaskDto TaskSelectById(int taskid);

    }
}
