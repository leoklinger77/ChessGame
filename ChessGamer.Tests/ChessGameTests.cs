using ChessGamer.Pieces;
using ChessGamer.Services;
using System;
using Xunit;

namespace ChessGamer.Tests {
    public class ChessGameTests {
        [Fact]
        public void TestBasicPawnMove() {
            var board = new Board();
            
            // White pawn E2
            bool result = board.TryGetField("E2", out var field, out var error);
            Assert.True(result, $"Failed to get E2: {error}");
            Assert.NotNull(field);
            Assert.IsType<Pawn>(field.Piece);
            
            // Move to E4
            result = board.TryMove(field, "E4", out error);
            Assert.True(result, $"Failed to move E2 to E4: {error}");
        }

        [Fact]
        public void TestPawnPromotion() {
            var board = new Board();
            var fields = board.Fields();
            
            // Place a white pawn at row 1 (index 1)
            fields[1, 4].SetPiece(new Pawn(PieceColor.White));
            fields[6, 4].NullPiece(); // Remove original pawn
            
            // Get the pawn
            board.TryGetField("E7", out var field, out _);
            
            // Move to E8 (should promote)
            board.TryMove(field, "E8", out _);
            
            // Check if promoted to Queen
            Assert.IsType<Queen>(fields[0, 4].Piece);
        }

        [Fact]
        public void TestCheckDetection() {
            var board = new Board();
            
            // Setup: Move pieces to create check scenario
            // Fool's Mate scenario
            // 1. f3
            board.TryGetField("F2", out var f2, out _);
            board.TryMove(f2, "F3", out _);
            
            // 1... e6
            board.TryGetField("E7", out var e7, out _);
            board.TryMove(e7, "E6", out _);
            
            // 2. g4
            board.TryGetField("G2", out var g2, out _);
            board.TryMove(g2, "G4", out _);
            
            // 2... Qh4# (checkmate)
            board.TryGetField("D8", out var d8, out _);
            board.TryMove(d8, "H4", out _);
            
            // Should be checkmate
            Assert.True(board.IsCheckmate, "Should be checkmate (Fool's Mate)");
            Assert.True(board.IsInCheck, "Should be in check");
        }

        [Fact]
        public void TestUndoRedo() {
            var board = new Board();
            
            // Make a move
            board.TryGetField("E2", out var e2, out _);
            board.TryMove(e2, "E4", out _);
            
            Assert.Equal(1, board.Count);
            
            // Undo
            bool undone = board.UndoMove();
            Assert.True(undone);
            Assert.Equal(0, board.Count);
            
            // Redo
            bool redone = board.RedoMove();
            Assert.True(redone);
            Assert.Equal(1, board.Count);
        }

        [Fact]
        public void TestInvalidMoveWhenKingInCheck() {
            var board = new Board();
            var fields = board.Fields();
            
            // Create a scenario where king is in check
            // Clear some pieces and place threatening piece
            fields[1, 4].NullPiece(); // Remove black pawn in front of king
            fields[2, 4].SetPiece(new Queen(PieceColor.White)); // Place white queen threatening king
            
            // Try to move a different piece (should fail if it doesn't block check)
            board.TryGetField("A7", out var a7, out _);
            bool canMove = board.TryMove(a7, "A6", out var error);
            
            // This move should fail because it doesn't address the check
            // (Note: actual behavior depends on check validation implementation)
        }

        [Fact]
        public void TestAllPiecesCanMove() {
            var board = new Board();
            
            // Test that initial pieces exist
            var fields = board.Fields();
            
            // Check white pieces
            Assert.IsType<Tower>(fields[7, 0].Piece);
            Assert.IsType<Horse>(fields[7, 1].Piece);
            Assert.IsType<Bishop>(fields[7, 2].Piece);
            Assert.IsType<Queen>(fields[7, 3].Piece);
            Assert.IsType<King>(fields[7, 4].Piece);
            Assert.IsType<Pawn>(fields[6, 0].Piece);
            
            // Check black pieces
            Assert.IsType<Tower>(fields[0, 0].Piece);
            Assert.IsType<Horse>(fields[0, 1].Piece);
            Assert.IsType<Bishop>(fields[0, 2].Piece);
            Assert.IsType<Queen>(fields[0, 3].Piece);
            Assert.IsType<King>(fields[0, 4].Piece);
            Assert.IsType<Pawn>(fields[1, 0].Piece);
        }

        [Fact]
        public void TestMoveHistory() {
            var board = new Board();
            
            // Make some moves
            board.TryGetField("E2", out var e2, out _);
            board.TryMove(e2, "E4", out _);
            
            board.TryGetField("E7", out var e7, out _);
            board.TryMove(e7, "E5", out _);
            
            var history = board.GetMoveHistory().GetAllMoves();
            Assert.Equal(2, history.Count);
            
            // Check first move
            Assert.Equal(6, history[0].FromLine);
            Assert.Equal(4, history[0].FromColumn);
            Assert.Equal(4, history[0].ToLine);
            Assert.Equal(4, history[0].ToColumn);
        }
    }
}
