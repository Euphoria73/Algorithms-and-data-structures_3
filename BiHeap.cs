using System;
using System.Collections;
using System.Collections.Generic;


namespace LabWork_3
{
    class BiHeap: IEnumerable
    {
        private List<int> items = new List<int>();
        public int Count => items.Count;

        public BiHeap() 
        {
        
        }
        public BiHeap(List<int> items)
        {
            this.items.AddRange(items);
            Sort(0);
        }
        public int Peek()
        {
            if (Count > 0)
            {
                return items[0];
            }
            else
            {
                return 0;
            }
        }
        public void Add(int item)
        {
            items.Add(item);

            var current = Count - 1;
            var parent = GetParentIndex(current);

            while (current > 0 && items[parent] < items[current])
            {
                Swap(current, parent);

                current = parent;
                parent = GetParentIndex(current);

            }
        }
        private static int GetParentIndex(int current)
        {
            return (current - 1) / 2;
        }
        public int GetMax()
        {
            int result = items[0];
            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }
        private void Sort(int current)
        {
            int max = current;
            int left;
            int right;

            while (current < Count)
            {
                left = 2 * current + 1;
                right = 2 * current + 2;

                if (left < Count && items[left] > items[max])
                {
                    max = left;
                }
                if (right < Count && items[right] > items[max])
                {
                    max = right;
                }
                if (current == max)
                {
                    break;
                }
                Swap(current, max);
                current = max;
            }
        }
        private void Swap(int current, int parent)
        {
            var temp = items[current];
            items[current] = items[parent];
            items[parent] = temp;
        }
        public void Print()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }           
        public IEnumerator GetEnumerator()
        {
            while (Count > 0)
            {
                yield return GetMax();
            }
        }
    }
}
