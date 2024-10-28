namespace rmbh.Entity.Interfaces
{
    public interface IHasPersonTracking
    {
        Guid CreatedUserId { set; get; }
        Guid ModifiedUserId { set; get; }
    }
}
