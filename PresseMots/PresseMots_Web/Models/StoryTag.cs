namespace PresseMots.Models
{
    public class StoryTag
    {

        public int StoryId { get; set; }
        public int TagId { get; set; }

        public Story Story { get; set; }
        public Tag Tag { get; set; }
    }
}
