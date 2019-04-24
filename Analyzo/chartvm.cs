using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace chartpie
{
    class chartvm
    {
      
        public List<ratio> rat { get; set; }
        public chartvm()
        {
            rat = new List<ratio>();

            rat.Add(new ratio { type = "Positive", quantity = 70 });
            rat.Add(new ratio { type = "Negative", quantity = 30 });
           
        }




    }
}
