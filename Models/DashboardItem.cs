namespace SimpleDashboardApi.Models
{
    public class DashboardItem
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public int Value { get; set; }
        public string? Text { get; set; }
    }
}
