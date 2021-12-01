namespace Day4_CoreViewModelApplication.Models
{
    public class DataRepository
    {
        public CustomerAddressModel DataSource()
        {
            Customer customer = new Customer()
            {
                CustomerId = 1,
                Name = "King Kochhar",
                Gender = "Male",
                Amount = 12000
            };

            Address address = new Address()
            {
                StreetName = "Civil Lines",
                City = "Delhi",
                Country = "India",
                Pincode = "100006"
            };

            CustomerAddressModel customerAddressModel = new CustomerAddressModel()
            {
                Customer = customer,
                Address = address,
                Title = "Customer Address Information"
            };

            return customerAddressModel;
        }
    }
}
