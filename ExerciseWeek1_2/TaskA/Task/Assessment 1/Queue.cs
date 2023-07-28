using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    class Queue
    {
        private readonly int maxSize = 20;
        private Task[] arrary;
        private int front = 0;
        private int back = 0;
        private int numItems = 0;   //declaring variables

        public Queue()
        {
            arrary = new Task[maxSize]; //new task class array with max size of maxSize
        }

        public Task Dequeue()   //dequeue task method
        {
            if (EmptyQ() == true)
            {
                return null;    //if the boolean for checking if the queue is empty returns a true value, return null when trying to dequeue
            }
            else
            {
                Task first = arrary[front]; 
                numItems--;         //number of items aka. count goes down
                if (++front == maxSize)
                {
                    front = 0;      //changes front to be at the 0th value in the queue
                }                   ////if the front of the queue attempts to pass the maxsize
                return first;
            }
        }
        public void Enqueue(Task taskEntry)
        {
            if (FullQ() == true)
            {
                return;         //if the boolean for checking if the queue is full returns a true value, return when trying to enqueue
            }
            else
            {
                arrary[back] = taskEntry;
                numItems++;     //number of items aka. count goes up
                if (++back == maxSize)      //changes back to be at 0th value in the queue 
                {                           //if the back of the queue attempts to pass the maxsize
                    back = 0;
                }
            }
        }
        public bool EmptyQ()
        {
            return numItems == 0; //if the back of the queue is at the 0th value in the queue it means the queue is empty
        }
        public bool FullQ()
        {
            return numItems == maxSize;    //if the back of the queue is at the max size number of 20 in the queue it means its full
        }
        public int NumItems()
        {
               //if the empty queue bool returns true it means the number of items is 0 as the queue is empty
                return numItems;    //returns the current number of items
        }
        public Task Peek()
        {
            if (EmptyQ() == true)
            {
                Task empty = new Task("Queue is Empty");    //creates a new task which outputs queue is empty
                return empty;                               //this task does not get added to the queue or count as it wasnt enqueued
            }
            else
            {
                Task first = arrary[front];     //task at the top of the queue
                return first;
            }
        }
    }
}
