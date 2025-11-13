## 📸 Gameplay Screenshots (Step-by-Step)

Below is a complete walkthrough of the game flow with real console screenshots.

---

### 🧩 1. Game Starts — User Chooses Number of Snakes
<img width="696" height="560" alt="Screenshot 2025-11-13 193602" src="https://github.com/user-attachments/assets/c5ac6897-57a7-4bc5-b514-ac8daefdef5e" />

The game begins by asking the player to enter how many **Snakes** should be placed on the board.  
Input validation ensures the user enters a number within the allowed range.

---

### 🪜 2. User Chooses Number of Ladders
<img width="634" height="561" alt="Screenshot 2025-11-13 193615" src="https://github.com/user-attachments/assets/9186815b-2d16-4b58-85fd-067c2a36faf1" />

Next, the player is asked to enter how many **Ladders** to generate.  
The UI validates this input as well.

---

### 🎲 3. First Board Rendering — Game Begins


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
<img width="644" height="551" alt="Screenshot 2025-11-13 193632" src="https://github.com/user-attachments/assets/37a88ad2-81eb-4eb7-b612-ced2487f4103" />

Player 1 rolled a **3** and moved from **0 → 3**.  
Now it's Player 2’s turn.  
The UI prompts Player 2 to press **SPACE** to roll the dice.

---

### 🎮 5. Endgame Scenario — Player is Near Winning
<img width="656" height="556" alt="Screenshot 2025-11-13 193746" src="https://github.com/user-attachments/assets/401d31ae-42aa-47ad-8d26-0319741c77c5" />

Here Player 1 rolled an **8** and moved from **88 → 96**.  
Player 2 is prompted for their turn, but the win is close.

---

### 🏁 6. Player Wins the Game
<img width="656" height="556" alt="Screenshot 2025-11-13 193746" src="https://github.com/user-attachments/assets/d39aeceb-8d63-4270-a6fa-cee4063115de" />

Player 1 reaches the final cell (100) and wins:  
- Dice rolled: 8  
- Move: **96 → 100**  
- UI displays **"Game Over! Congrats! Player 1 Won!"**

---

### 🔁 7. Play Again or Exit
<img width="643" height="561" alt="Screenshot 2025-11-13 193757" src="https://github.com/user-attachments/assets/e43f0f89-a33d-445b-b2ed-3b470aa8ed4e" />

The player can choose:  
- Press **Y** → restart the game  
- Press any other key → exit  

## 🎉 End of Game
---


This concludes a full gameplay cycle.
