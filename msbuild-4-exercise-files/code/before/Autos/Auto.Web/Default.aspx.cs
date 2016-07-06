using System;
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
