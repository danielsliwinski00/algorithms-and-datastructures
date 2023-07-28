using System;
using System.IO;
using System.Collections.Generic;

namespace Assessment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentlist = new Student[3];

            string[] name = { "john", "samuel", "tom" };                    //create arrays
            int[] id = { 003, 001, 006 };

            for (int i = 0; i < studentlist.Length; i++)        //for loop until studentlist length
            {
                studentlist[i] = new Student(id[i], name[i]);   //create new students with the id and name added 
            }

            Console.Write("BEFORE SORT: "); //show order before sort

            foreach (Student student in studentlist)
            {
                Console.Write(student);
            }

            InsertSortGen(studentlist); //insertion sort for studentlist 

            Console.Write(" AFTER SORT: "); //show order after sort

            foreach (Student student in studentlist)
            {
                Console.Write(student);
            }
        }

        static public void InsertSortGen<T>(T[] n) where T : IComparable //generic insertion sort
        {
            for (int i = 1; i < n.Length; i++)
            {           
                T value = n[i];
                int j = i;

                for (; j > 0 && value.CompareTo(n[j-1]) < 0; j--)   //using *CompareTo* because its generic 
                {
                    n[j] = n[j - 1];
                }
                n[j] = value;
            }
        }

        public class Student : IComparable  
        {
            private int id;
            private string name;

            public Student(int id, string name) //constructor with two argument
            {
                this.id = id;
                this.name= name;
            }

            public string Name 
            { 
                get { return name; } 
                set { name = value; } 
            }
            public int ID 
            { 
                get { return id; } 
                set { id = value; } 
            }

            public override string ToString() //for display
            {
                return "[ID: " + ID + " Name: " + Name + "] ";
            }
            public int CompareTo(Object obj)    //for IComparable
            {
                Student other = (Student)obj;
                return ID.CompareTo(other.ID);
            }
        }
    }
}
