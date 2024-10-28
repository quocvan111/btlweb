using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLLTW_webBanQuanAo
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCart();
            }
        }

        private void BindCart()
        {
            List<ItemCart> list = (List<ItemCart>)Application["itemCart"];
            ListViewCart.DataSource = list;
            ListViewCart.DataBind();
        }

        protected void ListViewCart_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteItem")
            {
                int itemId = int.Parse(e.CommandArgument.ToString());
                List<ItemCart> itemCart = (List<ItemCart>)Application["itemCart"];

                // Find and remove the item by ID
                ItemCart itemToRemove = itemCart.Find(item => item.Id == itemId);
                if (itemToRemove != null)
                {
                    itemCart.Remove(itemToRemove);
                }

                // Rebind the updated list to the ListView
                Application["itemCart"] = itemCart;
                BindCart();
            }
        }
    }
}
