namespace MyPortfolio.Core.Entities
{
    public class PortfolioItems : EntityBase
    {
        public string project_name { get; set; }
        public string description { get; set; }
        public string image_url { get; set; }
    }
}
