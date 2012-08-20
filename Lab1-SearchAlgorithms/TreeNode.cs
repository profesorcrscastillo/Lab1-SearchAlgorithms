using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Lab1_SearchAlgorithms
{
    public class TreeNode
    {
        public string City { get; set; }

        public decimal Distance { get; set; }

        public List<TreeNode> ChildNodes { get; set; }

        public TreeNode()
        {
          
        }

        public TreeNode(string city, decimal distance, List<TreeNode> childNodes)
        {
            City = city;
            Distance = distance;
            ChildNodes = childNodes;
        }

        /// <summary>
        /// This method grabs all ChildNodes for this TreeNode
        /// </summary>
        public void LoadChildNodes()
        {
            this.ChildNodes = new List<TreeNode>();

            var paths1 = from p in XElement.Load("C://Map.xml").Elements("Path")
                          where p.Element("City2").Value.ToLower().Equals(this.City.ToLower())
                          select p;

            foreach (var path in paths1)
            {
                this.ChildNodes.Add(new TreeNode(path.Element("City1").Value.ToString(), Decimal.Parse(path.Element("Distance").Value), new List<TreeNode>()));
            }

            var paths2 = from p in XElement.Load("C://Map.xml").Elements("Path")
                          where p.Element("City1").Value.ToLower().Equals(this.City.ToLower())
                          select p;

            foreach (var path in paths2)
            {
                TreeNode node = new TreeNode();
                node.City = path.Element("City2").Value.ToString();
                node.Distance = Decimal.Parse(path.Element("Distance").Value);
                node.ChildNodes = new List<TreeNode>();

                this.ChildNodes.Add(node);
            }
            
        }
       
    }
}