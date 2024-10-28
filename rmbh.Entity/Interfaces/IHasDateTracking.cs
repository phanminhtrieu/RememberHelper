namespace rmbh.Entity.Interfaces
{
    public interface IHasDateTracking
    {
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}
