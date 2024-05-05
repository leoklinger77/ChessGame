namespace ChessGamer.Services {
    public class SelectPosition {
        public Field Origin { get; set; }
        public Field Destination { get; set; }

        public SelectPosition(Field origin, Field destination) {
            Origin = origin;
            Destination = destination;
        }

        public string GetOriginKey() {
            return $"Column: {Origin.Column} | Row: {Origin.Row}";
        }
        public string GetDestinationKey() {
            return $"Column: {Destination.Column} | Row: {Destination.Row}";
        }
    }
}
