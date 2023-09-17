namespace EmployeeHomework.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public Employee EmployeeID { get; set; }
        public int OrderDate { get; set; }
        public int ShipCountry { get; set; }
    }
}
