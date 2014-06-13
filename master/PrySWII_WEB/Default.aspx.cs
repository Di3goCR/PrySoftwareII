using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void img1_Click(object sender, ImageClickEventArgs e)
    {
        imgview.ImageUrl = "~/Images/Clinica.jpg";
    }
    protected void img2_Click(object sender, ImageClickEventArgs e)
    {
        imgview.ImageUrl = "~/Images/Clinica2.jpg";
    }
    protected void img3_Click(object sender, ImageClickEventArgs e)
    {
        imgview.ImageUrl = "~/Images/Clinica3.jpg";

    }
    protected void img4_Click(object sender, ImageClickEventArgs e)
    {
        imgview.ImageUrl = "~/Images/Clinica4.jpg";
    }
    protected void img5_Click(object sender, ImageClickEventArgs e)
    {
        imgview.ImageUrl = "~/Images/Clinica5.jpg";
    }
}