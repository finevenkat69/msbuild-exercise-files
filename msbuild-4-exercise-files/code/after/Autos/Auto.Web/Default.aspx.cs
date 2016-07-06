using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Automobiles;

namespace Auto.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            LoadAuto();
        }

        private void LoadAuto()
        {
             var mini = new MiniCooper();
            _carName.Text = mini.Name;
        }

        
    }
}
