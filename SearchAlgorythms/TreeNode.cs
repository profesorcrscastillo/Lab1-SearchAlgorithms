using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchAlgorythms
{
    public class TreeNode
    {
        
        #region Properties

        public int CityID { get; set; }

        public decimal Distance { get; set; }

        public List<TreeNode> ChildNodes { get; set; }

        #endregion

        #region Constructors

        public TreeNode()
        {
            ChildNodes = new List<TreeNode>();
        }

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods

        #endregion

    }
}
