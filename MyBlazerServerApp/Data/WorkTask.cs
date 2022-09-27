namespace MyBlazerServerApp.Data
{
    public class WorkTask
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? State { get; set; }
        public string? Type { get; set; }
        public DateTime? CreatedWhen { get; set; }
    }
}
