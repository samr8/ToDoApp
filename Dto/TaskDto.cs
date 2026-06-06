namespace ToDo.Dto
{
    public class TaskDto
    {
        public int TaskId { get; set; }
        public string? TaskName { get; set; }
        public string? TaskDescription { get; set; }
        public short? TaskStatusId { get; set; }
        public string? TaskStatusName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }

    public class TaskUpsertDto
    {
        public int TaskId { get; set; }
        public string? TaskName { get; set; }
        public string? TaskDescription { get; set; }
        public short? TaskStatusId { get; set; }
    }

}
