namespace rmbh.Entity.Interfaces
{
    /// <summary>
    /// CreateDate,
    /// ModifiedDate
    /// </summary>
    public interface IHasDateTracking
    {
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}
