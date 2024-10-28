namespace rmbh.Entity.Interfaces
{
    /// <summary>
    /// Day, Month, Year
    /// </summary>
    public interface IHasDateComponents
    {
        int? Day { get; set; }
        int? Month { get; set; }
        int? Year { get; set; }
    }
}
