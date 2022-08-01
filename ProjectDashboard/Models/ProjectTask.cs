namespace ProjectDashboard.Models
{
    public class ProjectTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
}