namespace Notee.Interfaces
{
    public interface IHasTimestamps
    {
        DateTime Created { get; set; }
        DateTime? Modified { get; set; }
        DateTime? Deleted { get; set; }
    }
}
