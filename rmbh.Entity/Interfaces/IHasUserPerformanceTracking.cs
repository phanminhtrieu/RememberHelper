using rmbh.Entity.Enums;

namespace rmbh.Entity.Interfaces
{
    /// <summary>
    /// TimeSpent,
    /// MasteryScore
    /// </summary>
    public interface IHasUserPerformanceTracking
    {
        long? TimeSpent { get; set; }
        MasteryScore? MasteryScore { get; set; }
    }
}
