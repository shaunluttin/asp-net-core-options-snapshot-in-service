using Microsoft.Extensions.Options;

namespace AspNetCoreOptionsSnapshotInService
{
    public class CustomerService
    {
        private readonly IOptionsSnapshot<SupplyApiClientHttpSettings> snapshot;

        public CustomerService(IOptionsSnapshot<SupplyApiClientHttpSettings> snapshot)
        {
            this.snapshot = snapshot;
        }

        public Customer GetCustomer()
        {
            return new Customer
            {
                SomeValue = snapshot.Value.SomeValue
            };
        }
    }
}
