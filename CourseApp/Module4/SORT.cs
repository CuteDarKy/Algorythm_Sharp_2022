﻿using System;

namespace CourseApp.Module4
{
    public class SORT
    {
        public static void GetSorting()
        {
            var numbWag = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();
            var sVal = s.Split(' ');
            var arrWag = new int[numbWag];
            var ansArr = new int[numbWag];
            for (int i = 0; i < numbWag; i++)
            {
                arrWag[i] = int.Parse(sVal[i]);
            }

            int megaKrut = 0;
            int iamGrut = 0;

            while (megaKrut != numbWag)
            {
                if (Stack.Empty() == true || (iamGrut < numbWag && arrWag[iamGrut] < Stack.Back()))
                {
                    Stack.Push(arrWag[iamGrut]);
                    iamGrut++;
                }
                else
                {
                    ansArr[megaKrut] += Stack.Back();
                    Stack.Pop();
                    megaKrut++;
                }
            }

            bool isAnswer = true;

            for (int i = 0; i < ansArr.Length - 1; i++)
            {
                if (ansArr[i] > ansArr[i + 1])
                {
                    isAnswer = false;
                }
            }

            if (isAnswer == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private class Stack
        {
            private static int[] buffer = new int[100000001];
            private static int top = -1;

            public static void Push(int a)
            {
                top++;
                buffer[top] = a;
            }

            public static void Pop()
            {
                top--;
            }

            public static int Size()
            {
                return top + 1;
            }

            public static bool Empty()
            {
                return top == -1;
            }

            public static void Clear()
            {
                top = -1;
            }

            public static int Back()
            {
                return buffer[top];
            }
        }
    }
}