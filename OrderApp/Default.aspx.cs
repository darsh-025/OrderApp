using OrderApp;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebServiceConsumerApp.SpecificServiceReference;

namespace WebServiceConsumerApp
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Create an instance of the specific service client
                var service = new SpecificServiceClient();

                // Call the method provided by the service client
                var orders = service.GetOrders();

                // Bind data to the GridView
                GridView1.DataSource = orders;
                GridView1.DataBind();
            }
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Get the data item (assuming your data source is a list of Order objects)
                Order order = (Order)e.Row.DataItem;

                // Find the OK button in the current row
                Button btnOK = (Button)e.Row.FindControl("btnOK");

                // Set the CommandArgument to the OrderID
                btnOK.CommandArgument = order.OrderID.ToString();
            }
        }
        protected void btnOK_Click(object sender, EventArgs e)
        {
            // Handle OK button click
            Button btnOK = (Button)sender;
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
        }
    }
}
