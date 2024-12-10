using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure__Proyect_
{
    internal class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node()
        {
            Value = 0;
            Next = null;
        }

        public Node(int data)
        {
            Value = data;
            Next = null;
        }
    }





    internal class Node_Doble
    {
        public int Value { get; set; }
        public Node_Doble? Next { get; set; }
        public Node_Doble? Prev { get; set; }

        public Node_Doble()
        {
            Value = 0;
            Next = null;
            Prev = null;
        }

        public Node_Doble(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }

        public override string ToString()
        {
            return Value.ToString() + ",";
        }
    }
}
