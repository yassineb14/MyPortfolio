namespace MyPortfolio.Core.Entities
{
    public class Address : EntityBase
    {
        public string street { get; set; }
        public string city { get; set; }
        public string number { get; set; }
        public Address address { get; set; }
    }
}
