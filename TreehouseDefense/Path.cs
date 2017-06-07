namespace TreehouseDefense {
    class Path {
        private readonly MapLocation[] _path; // _path means that it's a private field.

        public int Length => _path.Length;

        public Path(MapLocation[] path) {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep) {
            // Ternary if statement
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}
