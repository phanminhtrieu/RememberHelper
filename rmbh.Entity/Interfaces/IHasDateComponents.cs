namespace rmbh.Entity.Interfaces
{
    public interface IHasDateComponents
    {
        int? Day { get; set; }
        int? Month { get; set; }
        int? Year { get; set; }
    }
}
