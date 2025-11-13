## 📸 Gameplay Screenshots (Step-by-Step)

Below is a complete walkthrough of the game flow with real console screenshots.

---

### 🧩 1. Game Starts — User Chooses Number of Snakes
![Enter Snakes](/mnt/data/Screenshot 2025-11-13 193602.png)

The game begins by asking the player to enter how many **Snakes** should be placed on the board.  
Input validation ensures the user enters a number within the allowed range.

---

### 🪜 2. User Chooses Number of Ladders
![Enter Ladders](/mnt/data/Screenshot 2025-11-13 193615.png)

Next, the player is asked to enter how many **Ladders** to generate.  
The UI validates this input as well.

---

### 🎲 3. First Board Rendering — Game Begins
![First Board](/mnt/data/Screenshot 2025-11-13 193632.png)

The board is generated randomly:  
- `SH` = Snake Head  
- `ST` = Snake Tail  
- `LB` = Ladder Bottom  
- `LT` = Ladder Top  
- `G`  = Gold Cell  
- `P1`, `P2` = Player positions  

Player 1 rolls the dice and the game starts.

---

### 🧍‍♂️➡️ 4. Player Makes the First Move
![First Move](/mnt/data/Screenshot 2025-11-13 193723.png)

Player 1 rolled a **3** and moved from **0 → 3**.  
Now it's Player 2’s turn.  
The UI prompts Player 2 to press **SPACE** to roll the dice.

---

### 🎮 5. Endgame Scenario — Player is Near Winning
![Near Win](/mnt/data/Screenshot 2025-11-13 193746.png)

Here Player 1 rolled an **8** and moved from **88 → 96**.  
Player 2 is prompted for their turn, but the win is close.

---

### 🏁 6. Player Wins the Game
![Game Won](/mnt/data/Screenshot 2025-11-13 193757.png)

Player 1 reaches the final cell (100) and wins:  
- Dice rolled: 8  
- Move: **96 → 100**  
- UI displays **"Game Over! Congrats! Player 1 Won!"**

---

### 🔁 7. Play Again or Exit
![Restart Screen](/mnt/data/Screenshot 2025-11-13 193809.png)

The player can choose:  
- Press **Y** → restart the game  
- Press any other key → exit  

---

## 🎉 End of Game
The game ends gracefully with:

**“Thanks for playing!”**

This concludes a full gameplay cycle.
