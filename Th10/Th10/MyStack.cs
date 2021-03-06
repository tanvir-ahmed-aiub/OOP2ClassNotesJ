﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Th10
{
    class MyStack<T>
    {
        private T[] arr;
        private int top;

        public MyStack() {
            arr = new T[10];
            top = 0;
        }
        public void Push(T a) {
            arr[top++] = a;
        }
        public T Top() {
            return arr[top - 1];
        }
        public void Pop() {
            top--;
        }
        public void PrintStack() {
            for (int i = 0; i < top; i++) {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
