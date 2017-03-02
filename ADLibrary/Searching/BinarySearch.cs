﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADLibrary.Searching
{
    class BinarySearch
    {
        /// <summary>
        /// Binary Search for an item in a array and return its index.
        /// </summary>
        /// <param name="array">The array to search through.</param>
        /// <param name="item">The item to search for.</param>
        /// <returns>The index where the item can be found.</returns>
        public static int search<T>(T[] array, T item) where T : IComparable
        {
            int low = 0;
            int high = array.Length - 1;
            int midpoint;

            while (low <= high)
            {
                midpoint = low + (high - low) / 2;

                if (item.CompareTo(array[midpoint]) == 0)
                    return midpoint;
                else if (item.CompareTo(array[midpoint]) < 0)
                    high = midpoint - 1;
                else
                    low = midpoint + 1;
            }

            return -1;
        }
    }
}
