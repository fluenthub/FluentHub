namespace FluentHub.Uwp.Models
{
    public class PinnableRepository
    {
        public bool IsPinned { get; set; }

        public Repository PinnableItem { get; set; }
    }
}
