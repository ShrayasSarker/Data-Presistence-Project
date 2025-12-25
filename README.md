# BrickScore 🎮

BrickScore is a classic brick‑breaker game built in Unity with persistent data saving.  
Players enter their name, smash bricks to earn points, and compete for the highest score.  
The best score and player name are saved between sessions using JSON, so your achievements are remembered every time you play.

---

## ✨ Features
- 🧱 Brick‑breaker gameplay with paddle and ball mechanics
- 📝 Start menu with player name input
- 💾 Persistent high score saving using `JsonUtility` and `Application.persistentDataPath`
- 🏆 Best score display across sessions (player name + score)
- 🔄 Back button to return to menu
- ♻️ Reset button to clear saved scores
- 🎨 Simple, clean UI with TextMeshPro

---

## 🛠️ Tech Stack
- **Engine:** Unity
- **Language:** C#
- **UI:** TextMeshPro
- **Persistence:** JSON file saving (`savefile.json`)
- **Scene Management:** Unity SceneManager

---

## 🚀 How to Play
1. Launch the game.
2. Enter your name in the menu input field.
3. Press **Start** to begin.
4. Use the paddle to bounce the ball and break bricks.
5. Earn points and try to beat the best score.
6. Press **Back** to return to the menu or **Reset** to clear scores.

---

## 📂 Project Structure
Assets/ ├── Scenes/ │    ├── menu.unity │    └── main.unity ├── Scripts/ │    ├── MainManager.cs │    ├── UIManager.cs │    ├── Ball.cs │    ├── Brick.cs │    ├── Paddle.cs │    └── DeathZone.cs ├── Prefabs/ ├── Materials/ └── Settings/



---

## 📸 Screenshots
(Add screenshots of your menu, gameplay, and high score display here)
### Menu Screen
![Menu Screenshot](SS\Gameplay.png)

### Gameplay
![Gameplay Screenshot](SS\Menu.png)

---

## 📜 License
This project is for learning and demonstration purposes.  
Feel free to fork, modify, and experiment with it.

---

## 🔗 Connect
Created by **Shrayas**  
Let’s connect on [LinkedIn](https://www.linkedin.com) and share ideas about Unity & Game Development!
