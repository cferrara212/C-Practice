using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Can
    {

      // public  member variables
            public string color;
        public bool isOpen;
            public int percentageFull;



       // constructors

        public Can(string color)
        {
            this.color = color;
            isOpen = false;
            percentageFull = 100;

        }
       
        
        // public member method
        public void Open()
        {
            isOpen = true;
        }

        public void TakeSip()
        {
            percentageFull -= 10;
        }
    }
}
