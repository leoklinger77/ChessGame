# ♟️ Chess Game - C# Implementation

A fully functional chess game implementation in C# with both Console and GUI interfaces, featuring advanced chess rules including check, checkmate, move history, and special moves.

## 🎯 Features

### Core Gameplay
- ✅ **Complete Chess Rules** - All standard chess piece movements implemented
- ✅ **Check & Checkmate Detection** - Automatically detects when a king is in check or checkmate
- ✅ **Move Validation** - Prevents illegal moves, including moves that would put your own king in check
- ✅ **Pawn Promotion** - Automatic promotion to Queen when a pawn reaches the opposite end
- ✅ **Piece Capture** - Full capture mechanics with captured pieces tracking

### GUI Features (Windows Forms)
- 🎨 **Beautiful Graphical Interface** - Professional chess board with high-quality piece graphics
- 🖱️ **Click-to-Move** - Intuitive drag-and-drop or click-to-select interface
- ⏱️ **Game Timer** - Built-in timer for both players
- 📊 **Captured Pieces Display** - Visual counter showing captured pieces for each side
- ↩️ **Navigation Controls** - Undo, redo, stop, and play buttons
- 🎮 **New Game Button** - Easy game reset functionality
- 🎯 **Player Indicators** - Clear visual indication of whose turn it is (Robot vs You)

### Advanced Features
- 🔄 **Undo/Redo System** - Complete move history with ability to undo and redo moves
- 📝 **Move History** - Track all moves with chess notation
- 🎨 **Two Interfaces** - Console and Windows Forms GUI implementations
- ⚠️ **Turn Management** - Enforces proper turn order (White/Black)
- 🎯 **Valid Move Highlighting** - Shows valid moves when selecting a piece

## 🚀 Getting Started

### Prerequisites
- .NET 6.0 or higher
- Windows OS (for GUI version)

### Installation

1. Clone the repository:
```bash
git clone https://github.com/yourusername/ChessGame.git
cd ChessGame
```

2. Build the solution:
```bash
dotnet build ChessGamer.sln
```

### Running the Console Version

```bash
cd ChessGamer/bin/Debug/net6.0
./ChessGamer.exe
```

### Running the GUI Version

```bash
cd ChessGame.Gui/bin/Debug/net6.0-windows
./ChessGame.Gui.exe
```

Or simply double-click the executable in Windows Explorer.

#### GUI Controls
- **Click** on a piece to select it
- **Click** on a valid square to move
- **Undo/Redo Buttons** (◄/►) - Navigate through move history
- **Stop Button** (⏹) - Pause the game
- **Play Button** (▶) - Resume/start the game
- **New Gamer** - Start a new game
- **Timer Display** - Shows elapsed time for each player
- **Captured Pieces** - Visual counter for captured pieces on both sides

## 🎮 How to Play

### Console Version

1. The game displays the current board state
2. Enter the position of the piece you want to move (e.g., `E2`)
3. Enter the destination position (e.g., `E4`)
4. Special commands:
   - `undo` - Undo the last move
   - `redo` - Redo an undone move
   - `history` - Show complete move history

### Board Notation

```
8  T  C  B  D  R  B  C  T
7  P  P  P  P  P  P  P  P
6  _  _  _  _  _  _  _  _
5  _  _  _  _  _  _  _  _
4  _  _  _  _  _  _  _  _
3  _  _  _  _  _  _  _  _
2  P  P  P  P  P  P  P  P
1  T  C  B  D  R  B  C  T
   A  B  C  D  E  F  G  H
```

**Pieces:**
- `P` - Pawn (Peão)
- `T` - Tower/Rook (Torre)
- `C` - Horse/Knight (Cavalo)
- `B` - Bishop (Bispo)
- `R` - King (Rei)
- `D` - Queen (Dama)

## 📦 Project Structure

```
ChessGame/
├── ChessGamer/                 # Console application
│   ├── Pieces/                 # Chess piece implementations
│   │   ├── Piece.cs           # Abstract base class
│   │   ├── Pawn.cs
│   │   ├── Tower.cs           # Rook
│   │   ├── Horse.cs           # Knight
│   │   ├── Bishop.cs
│   │   ├── Queen.cs
│   │   ├── King.cs
│   │   └── PieceColor.cs      # Enum for piece colors
│   ├── Services/              # Game logic
│   │   ├── Board.cs           # Board management & game rules
│   │   ├── Field.cs           # Board square
│   │   ├── ChessConsole.cs    # Console UI
│   │   └── MoveHistory.cs     # Move tracking & undo/redo
│   └── Program.cs
├── ChessGame.Gui/             # Windows Forms GUI application
│   ├── Component/             # UI components
│   ├── ChessGui.cs
│   └── Program.cs
└── ChessGamer.Tests/          # Unit tests
    └── ChessGameTests.cs
```

## 🎯 Technical Highlights

### Object-Oriented Design
- **Abstract Base Class** - `Piece` class with polymorphic behavior
- **Inheritance** - Each piece type inherits from `Piece`
- **Encapsulation** - Proper use of properties and access modifiers
- **Enum for Colors** - Type-safe color representation with `PieceColor`

### GUI Architecture
- **Windows Forms** - Native Windows UI with custom controls
- **Component-Based Design** - Reusable chess piece components
- **Event-Driven** - Click handlers and game state management
- **Resource Management** - Embedded chess piece images and icons
- **Visual Feedback** - Real-time board updates and move validation

### Game Logic
- **Check Detection** - Scans all opponent pieces to detect threats to the king
- **Checkmate Algorithm** - Tests all possible moves to determine if escape is possible
- **Move Validation** - Simulates moves to prevent leaving king in check
- **History Pattern** - Stack-based undo/redo using Command pattern

### Code Quality
- ✅ No compilation errors
- ✅ Consistent naming conventions (English)
- ✅ Separation of concerns (Pieces, Services, UI)
- ✅ Proper exception handling
- ✅ Clean architecture with MVC-like pattern

## 🧪 Testing

Run the automated tests:

```bash
dotnet test ChessGamer.Tests/ChessGamer.Tests.csproj
```

The test suite includes:
- Basic movement validation
- Pawn promotion
- Check detection
- Undo/redo functionality
- Move history tracking

## 📊 Implementation Status

| Feature | Status | Notes |
|---------|--------|-------|
| Basic Moves | ✅ Complete | All pieces move correctly |
| Capture | ✅ Complete | Full capture mechanics |
| Check | ✅ Complete | Detects and prevents illegal moves |
| Checkmate | ✅ Complete | Game ends on checkmate |
| Pawn Promotion | ✅ Complete | Auto-promotes to Queen |
| Undo/Redo | ✅ Complete | Full history management |
| Move History | ✅ Complete | Track all moves |
| GUI Interface | ✅ Complete | Windows Forms with timer and controls |
| Console Interface | ✅ Complete | Text-based gameplay |
| Castling | ⚠️ In Progress | Structure ready, validation pending |
| En Passant | ⚠️ In Progress | Tracking ready, capture logic pending |
| Stalemate | 📋 Planned | Future implementation |

## 🛠️ Technologies Used

- **Language:** C# 10
- **Framework:** .NET 6.0
- **UI:** Windows Forms
- **Testing:** xUnit
- **IDE:** Visual Studio / VS Code

## 📸 Screenshots

### Windows Forms GUI
Professional graphical interface featuring:
- High-quality chess piece graphics
- Chessboard with alternating square colors
- Real-time game timer for both players
- Captured pieces counter with visual indicators
- Navigation controls (undo/redo/pause/play)
- Player turn indicators (Robot vs You)
- New game button for quick restarts

### Console Version
Text-based interface for:
- Terminal-based gameplay
- Learning chess notation
- Keyboard-only interaction

## 📝 License

This project is open source and available under the [MIT License](LICENSE).

## 🤝 Contributing

Contributions are welcome! Feel free to:
1. Fork the project
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Open a Pull Request

## 📧 Contact

For questions or suggestions, please open an issue on GitHub.

---

**Note:** This is a fully functional chess game suitable for learning C# programming, game development, and software architecture patterns.
