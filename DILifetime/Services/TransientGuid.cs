namespace DILifetime.Services
{
    public class TransientGuid: ITransientGuidService
    {
        private readonly Guid Id;

        public TransientGuid()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
