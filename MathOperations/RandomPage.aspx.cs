using System;
using System.Web.UI.WebControls;
namespace generate_page_runtime {
    public partial class RandomPage : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            output.Text = "Random Text";
        }
    }
}
