using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_and_Task2
{
    public class Task2
    {
        public void Tasks2()
        {
            int[][] arr = InitializeArr();
            PrintArr(arr);
            Console.WriteLine("\nAverage marks");
            Average_Marks(arr);
            Console.WriteLine("\nMinimum marks");
            Min_Marks(arr);
            Console.WriteLine("\nMaximum marks");
            Max_Marks(arr);
        }

        private int[][] InitializeArr()
        {
            Random r = new Random();
            int size_group = r.Next(3, 6);
            int size_student_group = 0;
            int[][] arr = new int[size_group][];


            for (int i = 0; i < size_group; i++)
            {
                size_student_group = r.Next(10, 31);
                arr[i] = new int[size_student_group];

                for (int j = 0; j < size_student_group; j++)
                {
                    arr[i][j] = r.Next(1, 101);
                }
            }
            return arr;
        }

        private void PrintArr(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Group " + (i + 1));
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private void Average_Marks(int[][] arr)
        {
            float average_marks_group = 0;
            float average_marks_flow = 0;

            float sum_group = 0;
            float sum_flow = 0;

            float count_students_group = 0;
            float count_students_flow = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum_group += arr[i][j];
                    count_students_group++;

                    sum_flow += arr[i][j];
                    count_students_flow++;
                }
                average_marks_group = sum_group / count_students_group;
                average_marks_flow = sum_flow / count_students_flow;

                Console.WriteLine("Average marks of the group[" + (i + 1) + "]: " + average_marks_group);
                sum_group = 0;
                count_students_group = 0;
            }

            Console.WriteLine("\nAverage marks of the flow: " + average_marks_flow);
        }

        private void Min_Marks(int[][] arr)
        {
            int min_mark_group = 0;
            int min_mark_flow = arr[0][0];

            for (int i = 0; i < arr.Length; i++)
            {
                min_mark_group = arr[i][0];

                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < min_mark_group)
                    {
                        min_mark_group = arr[i][j];
                    }
                    if (arr[i][j] < min_mark_flow)
                    {
                        min_mark_flow = arr[i][j];
                    }
                }
                Console.WriteLine("Minimum mark of the group[" + (i + 1) + "]: " + min_mark_group);
                min_mark_group = 0;
            }
            Console.WriteLine("\nMinimum mark of the flow: " + min_mark_flow);
        }

        private void Max_Marks(int[][] arr)
        {
            int max_mark_group = 0;
            int max_mark_flow = arr[0][0];

            for (int i = 0; i < arr.Length; i++)
            {
                max_mark_group = arr[i][0];

                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max_mark_group)
                    {
                        max_mark_group = arr[i][j];
                    }
                    if (arr[i][j] > max_mark_flow)
                    {
                        max_mark_flow = arr[i][j];
                    }
                }
                Console.WriteLine("Maximum mark of the group[" + (i + 1) + "]: " + max_mark_group);
                max_mark_group = 0;
            }
            Console.WriteLine("\nMaximum mark of the flow: " + max_mark_flow);
        }
    }
}
