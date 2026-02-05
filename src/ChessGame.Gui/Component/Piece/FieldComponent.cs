namespace ChessGame.Gui.Component.Piece {
    using System;
    using System.Reactive.Subjects;

    public abstract class FieldComponent : UserControl {
        public Color Color { get; set; }
        public Subject<EventArgs> Subject { get; set; }
        public FieldComponent() {            
            Subject = new Subject<EventArgs>();
        }

        public abstract void SetInitializePiece(Color color);
    }
}
