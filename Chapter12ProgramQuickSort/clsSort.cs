using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12ProgramQuickSort
{
    class clsSort
    {
        int[] data;
        public clsSort(int[] vals)
        {
            data = vals; // Copies the rvalue
        }
        public void quickSort(int first, int last)
        {
            int start;
            int end;
            start = first;
            end = last;
            if (last - first >= 1)
            {
                int pivot = data[first];

                while (end > start) // While indexes don't match...
                { // Do left partition
                    while (data[start] <= pivot && start <= last && end >
                    start)
                        start++;
                    // Do right partition
                    while (data[end] > pivot && end >= first && end >= start)
                        end--;
                    if (end > start) // If right partition index smaller...
                        swap(start, end); // ...do a swap
                }
                swap(first, end); // Swap last element with pivot
                quickSort(first, end - 1); // Sort around partitions
                quickSort(end + 1, last);
            }
            else
            {
                return;
            }
        }

    


        public void swap(int pos1, int pos2)
        {
            int temp;
            temp = data[pos1];
            data[pos1] = data[pos2];
            data[pos2] = temp;
        }
    } 
}
    
