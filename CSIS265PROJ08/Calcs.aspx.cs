using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using csis265proj08.models;
using log4net;

namespace CSIS265PROJ08
{
    public partial class Calcs : System.Web.UI.Page
    {
        RectangleManager rectangleManager;
        private static readonly log4net.ILog logger = LogManager.GetLogger("MyLogger");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                // the user has interacted with an already loaded page in their browser
                dislpayOutput.Text = string.Empty;
                logger.Debug("page is being posted back");
            }
            else
            {
                // this is the first time the page is being show in the browser
                rectangleManager = new RectangleManager();
                logger.Debug(" first time page is being loaded...");
            }
        }

        protected void btnAddRectangle_Click(object sender, EventArgs e)
        {
            try
            {
                rectangleManager = new RectangleManager();

                if (Session["rectangleManager"] != null)
                    rectangleManager = (RectangleManager)Session["rectangleManager"];

                double length = Convert.ToDouble(txtLength.Text);
                double width = Convert.ToDouble(txtWidth.Text);

                rectangleManager.AddRectangle(length, width);
                rectangleManager.TotalRectanglePerimeter();
                rectangleManager.TotalRectangleArea();
                rectangleManager.AverageRectanglePerimeter();
                rectangleManager.AverageRectangleArea();

                Session["rectangleManager"] = rectangleManager;

                txtLength.Text = string.Empty;
                txtWidth.Text = string.Empty;
                logger.Debug($"length is: {length}");
                logger.Debug($"width is: {width}");

            }
            catch (Exception ex)
            {
                dislpayOutput.Text = "Please enter valid data";
                logger.Debug($"exception is: { ex.Message}");
            }
        }

        protected void btnDisplayOutput_Click(object sender, EventArgs e)
        {
            rectangleManager = new RectangleManager();
            rectangleManager = (RectangleManager)Session["rectangleManager"];
            dislpayOutput.Text = $"TTL perm: {rectangleManager.TotalRectanglePerimeter()} TTL area: {rectangleManager.TotalRectangleArea()}" +
                $" AVG perm: {rectangleManager.AverageRectanglePerimeter()} AVG area: {rectangleManager.AverageRectangleArea()}";

            logger.Debug($"message is: {dislpayOutput.Text}");

        }
    }
}