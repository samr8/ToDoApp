using ToDo.Dto;

namespace ToDo.Services
{
    public interface ITaskService
    {
        List<TaskDto> SelectAll();

    }
}
