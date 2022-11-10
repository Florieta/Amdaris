using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionClass
{
    public class GenericCollection<T>
    {
        private T[] arr = new T[3];
        private int currentIndex = 0;

        public T GetItemByIndex(int index) =>  arr[index];
        
        public void SetItemByIndex(int index, T item) => arr[index] = item;


        public void SwapByIndexs(int firstIndex, int secondIndex)
        {
            var first = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = first;
        }
    }
}
