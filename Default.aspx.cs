using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Your name: " + nameInput.Text + "<br/>Your age: " + ageInput.Text;
        }
    }
}