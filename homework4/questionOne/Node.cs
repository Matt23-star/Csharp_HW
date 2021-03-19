using System;
using System.Collections.Generic;
using System.Text;

namespace questionOne
{
    //链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
}
