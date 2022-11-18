using System;
using System.Collections.Generic;
using System.Text;

namespace K19329862_PROG7312_Task1
{
    class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeItem<T> Parent {get; set; }
        public List<TreeNode<T>> Children { get; set; }

    }
}
