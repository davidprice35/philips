using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;

using System.Data.Common;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Syncfusion.JavaScript.Models;


using Syncfusion.JavaScript.Web;


public partial class competitive_info_Clinical : System.Web.UI.Page
{
    List<Orders> order = new List<Orders>();
    protected void Page_Load(object sender, EventArgs e)
    {
        BindDataSource();
    }
    private void BindDataSource()
    {
        int code = 10000;
        for (int i = 1; i < 5; i++)
        {
            order.Add(new Orders(code + 1, "TOMSP", i + 0, 2.3 * i, "Münster", "Toms Spezialitäten", new DateTime(1991, 05, 15), "Germany", "44087", false));
            
           
           
            code += 5;
        }

        //this.Grid1.Columns[0].Visible = false;
        //this.Grid1.Columns[0].IsPrimaryKey = true;


        this.Grid1.DataSource = order;
        this.Grid1.DataBind();

        
    }

    [Serializable]
    public class Orders
    {
        public Orders()
        {

        }
        public Orders(long OrderId, string CustomerId, int EmployeeId, double Freight, string ShipCity, string ShipName,
            DateTime OrderDate, string ShipCountry, string ShipPostalCode, bool Verified)
        {
            this.OrderID = OrderId;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.ShipCity = ShipCity;
            this.ShipCity1 = ShipCity;
            this.ShipCity2 = ShipCity;
            this.ShipCity3 = ShipCity;
            this.ShipCity4 = ShipCity;
            this.ShipCity5 = ShipCity;
            this.ShipName = ShipName;
            this.OrderDate = OrderDate;
            this.ShipCountry = ShipCountry;
            this.ShipPostalCode = ShipPostalCode;
            this.Verified = Verified;
        }
        public long OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public double Freight { get; set; }
        public string ShipCity { get; set; }
        public string ShipCity1 { get; set; }
        public string ShipCity2 { get; set; }
        public string ShipCity3 { get; set; }
        public string ShipCity4{ get; set; }
        public string ShipCity5 { get; set; }
        public string ShipName { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCountry { get; set; }
        public string ShipPostalCode { get; set; }
        public bool Verified { get; set; }
    }

}
