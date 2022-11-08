using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProject.CarPark.Models
{
    public class MyCars : IEnumerable<MyCars>
    {
        List<MyCars> mylist = new List<MyCars>();

        public MyCars this[int index]
        {
            get { return mylist[index]; }
            set { mylist.Insert(index, value); }
        }

       
        public IEnumerator<MyCars> GetEnumerator()
        {
            return mylist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
