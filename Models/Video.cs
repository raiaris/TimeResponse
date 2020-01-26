namespace VideoAPI.Models
{
    public class Video
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public double Duration { get; set; }
        public long Timestamp { get; set; }
    }
}
