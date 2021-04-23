using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace KanbanAngularApplication.Models
{
    public class KanbanTasks
    {
        public static List<KanbanTasks> TaskDetails = new List<KanbanTasks>();
        public KanbanTasks()
        {
        }
        public KanbanTasks(int Id, string Status, string Summary, string Assignee)
        {
            this.Id = Id;
            this.Status = Status;
            this.Summary = Summary;
            this.Assignee = Assignee;
        }
        public static List<KanbanTasks> GetKanbanTasks()
        {
            TaskDetails.Add(new KanbanTasks { Id = 1, Status = "Open", Summary = "Analyze the new requirements gathered from the customer.", Assignee = "Nancy Davloio" });
            TaskDetails.Add(new KanbanTasks { Id = 2, Status = "InProgress", Summary = "Improve application performance", Assignee = "Andrew Fuller" });
            TaskDetails.Add(new KanbanTasks { Id = 3, Status = "Close", Summary = "Arrange a web meeting with the customer to get new requirements.", Assignee = "Janet Leverling" });
            TaskDetails.Add(new KanbanTasks { Id = 4, Status = "InProgress", Summary = "Fix the issues reported in the IE browser.", Assignee = "Janet Leverling" });
            TaskDetails.Add(new KanbanTasks { Id = 5, Status = "Open", Summary = "Fix the issues reported by the customer.", Assignee = "Steven walker" });
            return TaskDetails;
        }
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("Status")]
        public string Status { get; set; }
        [JsonPropertyName("Summary")]
        public string Summary { get; set; }
        [JsonPropertyName("Assignee")]
        public string Assignee { get; set; }
    }
}
