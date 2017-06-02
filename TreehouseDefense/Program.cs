using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Map map = new Map(8, 5);

                //map.Width = 8; //[1]
                //map.Height = 5; //[1]

                //Point point /*[3]*/= new Point(4, 2); //[2]
                Point x = new MapLocation(4, 2); //[5.1]
                Point p = x; //[5.2]
                map.OnMap(new MapLocation(0, 0)); //[5.3]
                Console.WriteLine(x.DistanceTo(5, 5)); //[5.4]
                //bool isOnMap = map.OnMap(point); //[2][3]
                //Console.WriteLine(isOnMap);
                //int area = map.Width * map.Height; //[2]

                //Console.WriteLine(point.DistanceTo(5, 3)); //[4]
                //Console.WriteLine(x.DistanceTo(5, 3)); //[5.5]
                Console.WriteLine(x is MapLocation); //[5.6]
                Console.WriteLine(x is Point); //[5.7]

                Point point = new Point(0, 0); //[5.8]
                Console.WriteLine(point is MapLocation); //[5.9]

                //point = new Point(8, 5); //[3]
                //isOnMap = map.OnMap(point); //[3]
                //Console.WriteLine(isOnMap);
            }
        }
    }
}
