namespace ChessGamer.Services {
    public class ChessConsole {
        private IDictionary<int, string> _numToColumn = new Dictionary<int, string>() {
            { 0, "A" },
            { 1, "B" },
            { 2, "C" },
            { 3, "D" },
            { 4, "E" },
            { 5, "F" },
            { 6, "G" },
            { 7, "H" },
        };
        private readonly Board board;

        public ChessConsole() {
            board = new Board();
        }

        public void StartGamer() {
            Field field;
            do {
                do {
                    Console.Clear();
                    ShowBoard();

                    if (!TryToReadKey(out field)) {
                        Console.Clear();
                        continue;
                    }
                } while (field == null);

                ShowBoard();

                if (!TryFromReadKey(field)) {
                    Console.ReadKey();
                }
            } while (true);
        }

        private void Header() {
            Console.WriteLine();
            Console.Write($"Move {board.Count}");
            Console.WriteLine();
            if (board.IsWhite) {
                Console.WriteLine("White's move");
            } else {
                Console.WriteLine("Black's move");
            }

            CapturePiece();
        }

        private bool TryToReadKey(out Field field) {
            Console.WriteLine();
            Console.Write("To: ");
            var to = Console.ReadLine();
            if (!board.TryGetField(to.ToUpper(), out field, out var ransom)) {
                Console.Write(ransom);
                Console.ReadKey();
                return false;
            }
            Console.Clear();
            return true;
        }

        private bool TryFromReadKey(Field field) {
            Console.WriteLine();
            Console.Write("From: ");
            var from = Console.ReadLine();
            if (!board.TryMove(field, from.ToUpper(), out var ransom)) {
                Console.Write(ransom);
                return false;
            }
            Console.Clear();
            return true;
        }

        private void CapturePiece() {
            var capture = board.CaptureFields();
            foreach (var item in capture) {
                if (item.Value.Count > 0) {
                    if (item.Key == board.ColorWhite) {
                        Console.WriteLine($"White's piece capture ");
                    } else {
                        Console.WriteLine($"Black's piece capture ");
                    }
                    foreach (var piece in item.Value) {

                        Console.Write($"{piece.ToString().Trim()} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private void ShowBoard() {
            Header();
            Console.WriteLine();
            for (int i = 0; i < 8; i++) {
                var line = 8 - i;
                Console.Write($"{line} ");
                for (int j = 0; j < 8; j++) {
                    var field = board.Fields()[i, j];
                    Write(field);
                }
                Console.WriteLine();
            }

            Console.Write("  ");
            for (int i = 0; i < 8; i++) {
                if (_numToColumn.TryGetValue(i, out var field)) {
                    Console.Write($" {field} ");
                }
            }
            Console.WriteLine();
        }

        private void Write(Field field) {
            if (field.ValidPosition || field.FieldAttacked) {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }

            if (field.Piece == null) {
                Console.Write(field.ToString());
            } else if (field.Piece != null && field.Piece.Color == board.ColorBlack) {
                Console.ForegroundColor = field.Piece.Color;
                Console.Write(field.ToString());
                Console.ForegroundColor = ConsoleColor.White;
            } else if (field.Piece != null && field.Piece.Color == board.ColorWhite) {
                Console.Write(field.ToString());
            }

            board.ClearMarkedFields(field);
        }
    }
}
