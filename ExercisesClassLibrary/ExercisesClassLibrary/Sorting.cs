﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesClassLibrary
{
    public static class Sorting
    {
        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }

            }
            return arr;
        }
    }
}
