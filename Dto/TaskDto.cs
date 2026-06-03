namespace To_Do.Dto
{
    public class TaskDto
    {
        public int TaskId { get; set; }
        public string? TaskName { get; set; }
        public string? TaskDescription { get; set; }
        public short? TaskStatusId { get; set; }
        public DateOnly? CreatedDate { get; set; }
        public DateOnly? UpdatedDate { get; set; }

    }

    public class TaskUpsertDto
    {
        public int TaskId { get; set; }
        public string? TaskName { get; set; }
        public string? TaskDescription { get; set; }
        public short? TaskStatusId { get; set; }
    }

}
