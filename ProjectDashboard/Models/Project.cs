namespace ProjectDashboard.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public virtual List<Tag> Tags { get; set; }
        public virtual List<ProjectTask> Tasks { get; set; }

    }
}
