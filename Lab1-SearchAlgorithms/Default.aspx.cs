using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Text;

namespace Lab1_SearchAlgorithms
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack){
                
             

                var cities1 = from p in XElement.Load("C://Map.xml").Elements("Path")
                              select p.Element("City1").Value;

                var cities2 = from p in XElement.Load("C://Map.xml").Elements("Path")
                              select p.Element("City2").Value;

                
                var cities = cities1.Concat(cities2).Distinct();
               
        

                // Execute the query 
                foreach (var city in cities.OrderBy(k => k))
                {
                    ddlOriginCity.Items.Add(new ListItem(city));
                    ddlDestinyCity.Items.Add(new ListItem(city));
                }
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            
            string route;
            
            route = this.SearchRoute(ddlOriginCity.SelectedValue, ddlDestinyCity.SelectedValue);
         
            if (route != string.Empty)
            {
                lblRouteTitle.Visible = true;
                lblRoute.Visible = true;
                lblRoute.Text = route;
            }
        }

        private string SearchRoute(string originCity, string endCity)
        {
            TreeNode root = new TreeNode(originCity, 0,  null );
            root.LoadChildNodes();

            DepthFirstSearch algorithm = new DepthFirstSearch(root);

            Stack<TreeNode> route = algorithm.Search(endCity);
            if (route != null)
            {
                StringBuilder strRoute = new StringBuilder();
                decimal total = 0;
                foreach (var node in route)
                {
                    strRoute.Append(node.City);
                    strRoute.Append(", ");
                    total += node.Distance;
                }
                strRoute.Append(string.Format(" Distancia total: {0}", total));

                return strRoute.ToString();
            }
            else
            {
                return "No encontro el camino";
            }   
        }
    }
}
