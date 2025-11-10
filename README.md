# 🎮 Tic Tac Toe (Console Edition)

A simple **two-player Tic Tac Toe game** built in **C#** for the console.  
Players take turns marking spaces on a 3×3 grid until one player wins or the game ends in a draw.

---

## 🧠 Overview

This program runs directly in the console.  
Each player chooses a cell numbered **1–9** to place their symbol (`X` or `O`).  
The game automatically checks for winning combinations after every move and highlights the winning line when someone wins.

---

## 🕹️ Gameplay Instructions

1. **Run the program**
   - In Visual Studio → press `Ctrl + F5`, or  
   - In terminal → run:
     ```bash
     dotnet run
     ```

2. The grid will display numbers **1–9**, each representing a cell:

 1 | 2 | 3
---+---+---
 4 | 5 | 6
---+---+---
 7 | 8 | 9
 
3. Player 1 uses **X**, Player 2 uses **O**.

4. Players take turns typing a number between **1–9** to mark their move.

5. Invalid or occupied cell inputs will show an error message and ask again.

6. The game ends when:
- One player gets **three in a row** (horizontally, vertically, or diagonally), or  
- All cells are filled (resulting in a **draw**).

---

## 🏆 Winning Example

 X | O | X
---+---+---
 O | X | O
---+---+---
[X]|[X]|[X]

🎉 Congratulations Player 1 (X) wins!
Winning line: 7, 8, 9

---

## 🧩 Key Features

✅ Clean console UI with numbered grid  
🔁 Turn-based input system  
🧠 Automatic win detection across all 8 possible lines  
🎯 Highlights the winning line in square brackets `[ ]`  
🚫 Input validation for invalid or already occupied cells  

---

## 🧱 Code Structure

| Function | Description |
|-----------|-------------|
| `GetWinningLine()` | Checks all 8 possible winning combinations and returns the winning indexes if found. |
| `PrintGrid(int[] highlight = null)` | Renders the 3×3 grid. If a winning line is found, highlights those cells. |
| *(main loop)* | Handles player turns, input validation, and win/draw detection. |

---

## ⚙️ Requirements

- **.NET 6.0 or later** (C# 9.0+)
- Works in **Visual Studio 2022** or via **.NET CLI**

### 🧩 Run using CLI
```bash
dotnet build
dotnet run
