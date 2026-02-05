namespace ChessGamer {
    using ChessGamer.Services;
    internal class Program {
        static void Main(string[] args) {
            ChessConsole chess = new ChessConsole();
            chess.StartGamer();
        }
    }
}