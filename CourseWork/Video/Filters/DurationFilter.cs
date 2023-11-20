namespace CourseWork.Video.Filters
{
    using System;
    using Abstract;

    public class DurationFilter : IFilter
    {
        public DurationFilter(TimeSpan duration)
        {
            Duration = duration;
        }
        
        public TimeSpan Duration { get; }
    }
}