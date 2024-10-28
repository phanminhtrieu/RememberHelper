using rmbh.Entity.Enums;

namespace rmbh.Entity.Interfaces
{
    public interface IHasUserPerformanceTracking
    {
        long? TimeSpent { get; set; }
        MasteryScore? MasteryScore { get; set; }
    }
}
