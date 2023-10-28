using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlylinkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {




        }


    }



    

    
    //list data structure
    internal class Slist
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Counter { get; set; }

        public Slist()
        {
            Head = null;
            Tail = null;
            Counter = 0;
        }


        private void InsertAttop(Node node)
        {
            //1- check if list is null
            if (Head  == null)
            {
                //list is empty 
                Head = node;
                Tail = node;
            }
            else
            {
                //Attach the list to the new node
                node.Next = Head;


                //Reassign Head to the new node to keep head at top of the stack

                Head = node;

            }
            Counter++;
        }

        //UI call

        public void AddToFront(int data)
        {
            Node temp = new Node(data);
            InsertAttop(temp);
        }



        private void InsertAtrear(Node node)
        {
            // check if list is empty 
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail = new node;


            }
        }


        public string ToPrint()
        {
            StringBuilder sb = new StringBuilder();

            if (Head == null)
            {
                //list is empty 
                sb.Append("stack is empty\n");
                return sb.ToString();

            }
            else
            {
                Node temp = null; //Create node to traverse list
                temp = Head;
                int pos = 1; //Node position

                while (temp != null)
                {
                    sb.Append("Node" + pos.ToString() + "-> " + temp.ToPrint() + "\n");
                    temp = temp.Next;
                    pos++;
                }

            }
            return sb.ToString();
        }


    };







   internal class Node
    {
       public int Data { get; set; }

       public Node Next { get; set; }


        //Constructor if a number is not given 
       public Node()
        {
            Data = 0;
            Next = null;
        }


        //Constructor used if a number is given
        public Node(int data)
        {
            Data = data;
            Next = null;
        }

        public string ToPrint()
        {
            return Data.ToString();
        }
    }
}


