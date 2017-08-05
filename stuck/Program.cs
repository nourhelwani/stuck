using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stuck
{
    class node
    {
        string data;


        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        node next;


        internal node Next
        {
            get { return next; }
            set { next = value; }
        }

    }
    class Stuck
    {
        node first;
        public void add(string x)
        {

            node new_node = new node();

            new_node.Data = x;
            new_node.Next = first;
            first = new_node;



        }
        public string pop()
        {

            node temp = first;
            first = first.Next;
            temp.Next = null;
            return temp.Data;
        }
        public int count()
        {
            node pointer;
            int count = 0;
            pointer = first;
            do
            {
                pointer = pointer.Next;
                count++;
            }
            while (pointer.Next != null);
            return count+1  ;
        }
        public void soreted()
        {
            int items_count = count();
            node temp = first;
            string[] sort = new string[items_count];
           //for fill the array
            for (int i = 0; i < items_count; i++)
            {
                sort[i] = temp.Data;
                temp = temp.Next;

            }
            //sorted array
            string s1 = "";
            string s2 = "";
            for (int t = 0; t < items_count; t++)
            {
                s1 = sort[t];
                for (int b = 0; b < items_count; b++)
                {
                    s2 = sort[b];
                    if (s1[0] > s2[0])
                    {
                        string temp1 = sort[t];
                        sort[t] = sort[b];
                        sort[b] = temp1;
                    }

                }
            }
            //clean stuck
            do
            {
                first.Data = null;
                first = first.Next;
                
            } while (first.Next!=null);
           
               //add new sorted data     
            for (int y = 0; y < items_count; y++)
            {
                add(sort[y]);
            }
            
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Stuck a = new Stuck();
            a.add("heloo");
            a.add("i");
            a.add("world");
            a.add("hoo");
            a.add("fuck");
            a.add("shit");
            a.add("a");
            a.add("b");
            int x = a.count();
            Console.WriteLine(a.count());
                        a.soreted();
                       
                        for (int i = 0; i < x; i++)
                        {
                            Console.WriteLine(a.pop());
                        }

        }
    }
}
