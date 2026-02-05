namespace ChessGamer.Tools {
    public static class Assistant {
        public static IDictionary<char, int> _columnTextToNum = new Dictionary<char, int>() {
            { 'A', 0 },
            { 'B', 1 },
            { 'C', 2 },
            { 'D', 3 },
            { 'E', 4 },
            { 'F', 5 },
            { 'G', 6 },
            { 'H', 7 },
        };

        public static IDictionary<char, int> _rowTextToNum = new Dictionary<char, int>() {
            { '1', 7 },
            { '2', 6 },
            { '3', 5 },
            { '4', 4 },
            { '5', 3 },
            { '6', 2 },
            { '7', 1 },
            { '8', 0 },
        };

        public static IDictionary<int, int> _columnTableToNum = new Dictionary<int, int>() {
            { 0, 0 },
            { 1, 1 },
            { 2, 2 },
            { 3, 3 },
            { 4, 4 },
            { 5, 5 },
            { 6, 6 },
            { 7, 7 },
        };

        public static IDictionary<int, int> _rowTableToNum = new Dictionary<int, int>() {
            { 1, 7 },
            { 2, 6 },
            { 3, 5 },
            { 4, 4 },
            { 5, 3 },
            { 6, 2 },
            { 7, 1 },
            { 8, 0 },
        };
    }
}
