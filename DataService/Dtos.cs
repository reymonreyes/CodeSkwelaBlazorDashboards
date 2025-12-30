namespace BlazorDashboards.Services.Dtos
{
    public class MonthlyData
    {
        private List<string> monthLabels = new List<string>
        {
            "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };

        public int Month { get; set; }
        public string MonthName { get { return monthLabels[Month - 1]; } }
        public decimal Total { get; set; }
    }

    public class ProductCategorySales
    {
        public string CategoryName { get; set; }
        public decimal Total { get; set; }
    }

    public class ProductSales
    {
        public string ProductName { get; set; }
        public decimal Total { get; set; }
    }

    public class CustomerSales
    {
        public string CustomerName { get; set; }
        public decimal Total { get; set; }
    }
}
