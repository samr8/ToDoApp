using ToDo.Dto;

namespace ToDo.Repositoris
{
    public interface ITaskRepository
    {
        List<TaskDto> SelectAll();
        
    }
}
