using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1_SearchAlgorithms
{
    public class DepthFirstSearch
    {

        private Stack<TreeNode> _searchStack;
        private Stack<TreeNode> _traceStack;
        private TreeNode _root;

        public DepthFirstSearch(TreeNode rootNode)
        {
            _root = rootNode;
            _searchStack = new Stack<TreeNode>();
            _traceStack = new Stack<TreeNode>();
        }

        /// <summary>
        /// This is the Depth First Search implementation
        /// </summary>
        /// <param name="destinyCity"></param>
        /// <returns></returns>
        public Stack<TreeNode> Search(string destinyCity)
        {
            TreeNode _current;
            _searchStack.Push(_root);

            while (_searchStack.Count != 0)
            {

                _current = _searchStack.Pop();
              
                if (_current.City == destinyCity)
                {
                    _traceStack.Push(_current);
                    return _traceStack;
                }
                else
                {
                    _traceStack.Push(_current);
                    _current.LoadChildNodes();
                    foreach (var childNode in _current.ChildNodes)
                    {
                        var x = from q in _traceStack
                                where q.City.ToLower().Equals(childNode.City.ToLower())
                                select q;

                        if (x.Count() == 0)
                        {
                            _searchStack.Push(childNode);
                        }
                    }
                }
            }
            return null;
        }
    }
}