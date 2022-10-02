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
            int age = int.Parse(ageInput.Text);
            double money = double.Parse(moneyInput.Text);

            if (((age > 18 || age < 18) && money >= 20) || (age <= 18 && money <= 20))
            {
                resultLabel.Text = String.Format("At {0} years old, You have {1} in your pocket, that seems reasonable", age, money) ;
            } else
            {
                resultLabel.Text = String.Format("At {0} years old, I would have expected you to have more than {1} in your pocket", age, money);
            }
            
        }
    }
}