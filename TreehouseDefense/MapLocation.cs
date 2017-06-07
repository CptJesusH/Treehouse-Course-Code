using System;

namespace TreehouseDefense {
    class MapLocation : Point //[2]
    {
        public MapLocation(int x, int y, Map map) : base(x, y) //[3]
        {
            if (!map.OnMap(this)) //[1]
            {
                //throw new System.Exception();
                throw new OutOfBoundsException(x + ", " + y + " is outside the boundries of the map.");
            }
        }

        public bool InRangeOf(MapLocation location, int range) {
            return DistanceTo(location) <= range;
        }
    }
}
