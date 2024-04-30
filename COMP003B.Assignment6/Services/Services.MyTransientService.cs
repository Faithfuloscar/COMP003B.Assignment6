using System.Security.AccessControl;

namespace COMP003B.Assignment6.Services
{
    public class MyTransientServices
    {
        // private field
        private readonly Guid _uniqueId;

        // default constructor
        public MyTransientServices()
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
