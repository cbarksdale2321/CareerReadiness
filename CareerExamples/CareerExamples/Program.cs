using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerExamples
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
        }
        //algorithm for getting distance in rectangle from a point
        public void distance(int[] rect, p)
        {
           
            
            var dx = Math.Max(rect.min.x - p.x, 0, p.x - rect.max.x);
            var dy = Math.Max(rect.min.y - p.y, 0, p.y - rect.max.y);
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
