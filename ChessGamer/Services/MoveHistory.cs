namespace ChessGamer.Services {
    using ChessGamer.Pieces;

    public class Move {
        public int FromLine { get; set; }
        public int FromColumn { get; set; }
        public int ToLine { get; set; }
        public int ToColumn { get; set; }
        public Piece MovedPiece { get; set; }
        public Piece CapturedPiece { get; set; }
        public int MoveNumber { get; set; }

        public Move(int fromLine, int fromColumn, int toLine, int toColumn, Piece movedPiece, Piece capturedPiece, int moveNumber) {
            FromLine = fromLine;
            FromColumn = fromColumn;
            ToLine = toLine;
            ToColumn = toColumn;
            MovedPiece = movedPiece;
            CapturedPiece = capturedPiece;
            MoveNumber = moveNumber;
        }

        public override string ToString() {
            var from = $"{(char)('A' + FromColumn)}{8 - FromLine}";
            var to = $"{(char)('A' + ToColumn)}{8 - ToLine}";
            var capture = CapturedPiece != null ? "x" : "-";
            return $"{MoveNumber}. {from}{capture}{to}";
        }
    }

    public class MoveHistory {
        private Stack<Move> _moves = new Stack<Move>();
        private Stack<Move> _undoneeMoves = new Stack<Move>();

        public int Count => _moves.Count;

        public void AddMove(Move move) {
            _moves.Push(move);
            // Clear redo stack when a new move is made
            _undoneeMoves.Clear();
        }

        public Move UndoMove() {
            if (_moves.Count == 0) {
                return null;
            }
            var move = _moves.Pop();
            _undoneeMoves.Push(move);
            return move;
        }

        public Move RedoMove() {
            if (_undoneeMoves.Count == 0) {
                return null;
            }
            var move = _undoneeMoves.Pop();
            _moves.Push(move);
            return move;
        }

        public bool CanUndo() => _moves.Count > 0;
        public bool CanRedo() => _undoneeMoves.Count > 0;

        public List<Move> GetAllMoves() {
            return _moves.Reverse().ToList();
        }

        public Move GetLastMove() {
            return _moves.Count > 0 ? _moves.Peek() : null;
        }

        public void Clear() {
            _moves.Clear();
            _undoneeMoves.Clear();
        }
    }
}
