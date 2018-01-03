using System;
using System.Threading.Tasks;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = (new Service()).DbEntities.Employees.Find(1).EmployeesDetails.JobTitle;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}