namespace CourseWork.Video.Filters
{
    using Abstract;

    public class SubtitlesAvailabilityFilter : IFilter
    {
        public SubtitlesAvailabilityFilter(bool isAvailable)
        {
            IsAvailable = isAvailable;
        }
        
        public bool IsAvailable { get; }
    }
}