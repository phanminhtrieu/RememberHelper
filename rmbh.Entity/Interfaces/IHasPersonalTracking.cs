namespace rmbh.Entity.Interfaces
{
    /// <summary>
    /// CreatedUserId,
    /// ModifiedUserId
    /// </summary>
    public interface IHasPersonTracking
    {
        Guid CreatedUserId { set; get; }
        Guid ModifiedUserId { set; get; }
    }
}
