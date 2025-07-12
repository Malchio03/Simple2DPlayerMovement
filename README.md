# 2D Player Controller in Unity

This Unity project contains a simple and modular **2D Player Controller** script written in C#.  
It allows the player to **move**, **jump**, **attack**, and **flip direction**, while handling **animations** and **ground detection**.

---

## Code Overview

### `Player.cs`

Main script that handles player input, movement, jumping, collision, flip, and animation logic.

### `PlayerAnimationEvents.cs`

Script attached to the visual child object with the Animator.  
Used to trigger methods at specific points in animations via **Animation Events**.

---

## How to Use

1. **Attach `Player.cs`** to your main player GameObject.
2. Ensure the player has a `Rigidbody2D`, and optionally a child with an `Animator`.
3. Set up your `Animator` with proper parameters: `xVelocity`, `yVelocity`, `isGrounded`, `attack`.
4. In the **attack animation**, add two **Animation Events**:
   - At the beginning: call `DisableMovementAndJump`
   - At the end: call `EnableMovementAndJump`
5. **Attach `PlayerAnimationEvents.cs`** to the child GameObject that contains the Animator component.

---

## 🎮 Controls

| Key / Input | Action         |
|-------------|----------------|
| A / D or ← / → | Move left/right |
| Space / ↑    | Jump           |
| Left Click   | Attack         |
