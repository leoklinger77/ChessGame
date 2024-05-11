namespace ChessGamer.Services {
    public class SelectPosition {
        public Field Origin { get; set; }
        public Field Destination { get; set; }

        public SelectPosition(Field origin, Field destination) {
            Origin = origin;
            Destination = destination;
        }

        public string GetOriginKey() {
            return $"Row: {Origin.Row} | Column: {Origin.Column}";
        }
        public string GetDestinationKey() {
            return $"Row: {Destination.Row} | Column: {Destination.Column}";
        }
    }
}
