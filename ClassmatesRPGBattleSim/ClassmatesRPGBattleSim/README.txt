# Classmates RPG Battle Simulator

This is a simple turn-based RPG battle simulator created in C# Windows Forms, using characters inspired by my classmates.

## Characters

*   **Debugger Dana:** ( A reliable fighter with consistent attack damage and moderate health.)
*   **Code Crusher Carlos:** ( Hits harder but with a wider damage range, and has slightly more health.)

## OOP Principles Applied

*   **Abstraction:** Demonstrated by the `ClassFighter` abstract base class. It defines the common interface (Attack, TakeDamage) and properties (Name, Health) that all fighters share, without providing a complete implementation for attack.
*   **Inheritance:** `DebuggerDana` and `CodeCrusherCarlos` classes inherit from `ClassFighter`. They automatically receive the common health management logic and properties, allowing them to specialize only the parts that differ (the Attack method).
*   **Polymorphism:** Shown when calling `player1.Attack()` or `player2.Attack()` from the `Form1` code. Although `player1` and `player2` are declared as `ClassFighter` type, the runtime executes the `Attack` method specific to the actual object type (`DebuggerDana` or `CodeCrusherCarlos`) held by the variable. This allows treating different character types uniformly in the battle loop.
*   **Encapsulation:** Implemented in the `ClassFighter` base class. Private fields (`name`, `currentHealth`, `maxHealth`) protect the internal state. Public properties provide controlled access (`get`). The `TakeDamage` method provides a controlled way to modify the `currentHealth`, preventing direct, potentially invalid, manipulation from outside the class.

## Exception Handling

*   The program uses `try-catch` blocks in the `btnStartBattle_Click` event handler to catch potential issues.
*   It specifically catches `ArgumentException` for user input errors (empty names, no character selected) and displays a user-friendly `MessageBox`.
*   A general `catch (Exception ex)` is included to handle any other unexpected runtime errors gracefully, preventing the application from crashing abruptly.

## Challenges Faced

*(Reflect on any difficulties you encountered)*
*   Getting the turn-based logic in the `while` loop exactly right, ensuring the battle stops as soon as health reaches zero.
*   Ensuring the UI updates correctly during or after the battle.
*   Deciding on appropriate health and damage ranges for characters to make battles feel balanced/interesting.
*   Mapping the selected string in the ComboBox back to the correct C# class type for instantiation (solved using a helper method and switch statement).

