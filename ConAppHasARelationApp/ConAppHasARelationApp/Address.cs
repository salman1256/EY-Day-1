namespace ConAppHasARelationApp
{
    public class Address
    {
        public string House { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"House: {House}, City: {City},Region: {Region},Postal Code: {PostalCode},Country: {Country}";
        }
    }
}
