namespace DILifetime.Services
{
    public class SingletonGuid: ISingletonGuidService
    {
        private readonly Guid Id;

        public SingletonGuid() 
        { 
            Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
