namespace DILifetime.Services
{
    public class ScopedGuid: IScopedGuidService
    {
        private readonly Guid Id;

        public ScopedGuid()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
