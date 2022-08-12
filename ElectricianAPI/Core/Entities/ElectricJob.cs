using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class ElectricJob: BaseEntity
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime DatePosted { get; set; }
        public DateTime? DateAttended { get; set; }
        public ICollection<JobImages> JobImages { get; set; }
        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }
    }
}
