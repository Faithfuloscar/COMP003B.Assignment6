namespace COMP003B.Assignment6.Services
{
    public class MyScopedService
    {
        // private field
        private readonly Guid _uniqueId;

        // default constructor
        public MyScopedService()
        {
            _uniqueId = Guid.NewGuid();
        }

        // public method that returns the _uniqueId value
        public Guid GetUniqueId()
        {
            return _uniqueId;
        }
    }
}
