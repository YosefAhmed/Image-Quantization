﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageQuantization
{
	public class HeapSort
	{
		public void Sort(Edge[] arr)
		{
			int n = arr.Length;

			// Build heap (rearrange array) 
			for (int i = n / 2 - 1; i >= 0; i--)
				heapify(arr, n, i);

			// One by one extract an element from heap 
			for (int i = n - 1; i >= 0; i--)
			{
				// Move current root to end 
				Edge temp = arr[0];
				arr[0] = arr[i];
				arr[i] = temp;

				// call max heapify on the reduced heap 
				heapify(arr, i, 0);
			}
		}

		//deletes a vertix and returns the size of the heap after deletion
		public int Delete(Edge[] arr,int i)
		{
			arr[i] = arr[arr.Length - 1];
			heapify(arr, arr.Length - 1, i);
			return arr.Length-1;
		}

		// To heapify a subtree rooted with node i which is 
		// an index in arr[]. n is size of heap 
		void heapify(Edge[] arr, int n, int i)
		{
			int largest = i; // Initialize largest as root 
			int l = 2 * i + 1; // left = 2*i + 1 
			int r = 2 * i + 2; // right = 2*i + 2 

			// If left child is larger than root 
			if (l < n && arr[l].weight > arr[largest].weight)
				largest = l;

			// If right child is larger than largest so far 
			if (r < n && arr[r].weight > arr[largest].weight)
				largest = r;

			// If largest is not root 
			if (largest != i)
			{
				Edge swap = arr[i];
				arr[i] = arr[largest];
				arr[largest] = swap;

				// Recursively heapify the affected sub-tree 
				heapify(arr, n, largest);
			}
		}

		/* A utility function to print array of size n */
		static void printArray(int[] arr)
		{
			int n = arr.Length;
			for (int i = 0; i < n; ++i)
				Console.Write(arr[i] + " ");
			Console.Read();
		}

	}

	// This code is contributed 
	// by Akanksha Rai(Abby_akku) 

}
