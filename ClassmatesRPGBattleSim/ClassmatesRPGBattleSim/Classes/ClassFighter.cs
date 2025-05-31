// In a file named ClassFighter.cs inside a 'Classes' folder

using System;

namespace ClassmatesRPGBattleSim.Classes
{
    /// <summary>
    /// Abstract base class for all battle characters.
    /// Demonstrates Abstraction and Encapsulation.
    /// </summary>
    public abstract class ClassFighter
    {
        // --- Encapsulation ---
        // Private backing fields to protect data
        private string name;
        private int maxHealth;
        private int currentHealth;

        // Public properties to access data, controlling how it's used
        public string Name
        {
            get { return name; }
            // No public setter ensures name is set only on creation
        }

        public int MaxHealth
        {
            get { return maxHealth; }
            // No public setter ensures max health is set only on creation
        }

        public int Health
        {
            get { return currentHealth; }
            // Protected setter allows derived classes or this class
            // to modify health, but not external unrelated classes directly.
            // This is an alternative to only using TakeDamage for all modifications.
            // For this project, TakeDamage is sufficient for health reduction.
            // Let's keep the setter private as per common encapsulation patterns,
            // and rely solely on TakeDamage/Healing methods (if healing existed).
            // Let's just use a private setter and manage via methods.
            // Or even simpler for this project: only get property, health modified by TakeDamage.
        }
        // Let's use this simple approach: Health only accessible via get
        // and modified internally or via specific methods like TakeDamage.


        /// <summary>
        /// Constructor for the base ClassFighter.
        /// </summary>
        /// <param name="name">The character's name.</param>
        /// <param name="maxHealth">The character's maximum health.</param>
        protected ClassFighter(string name, int maxHealth)
        {
            // Basic validation (demonstrating robustness)
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Character name cannot be empty.", nameof(name));
            }
            if (maxHealth <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxHealth), "Maximum health must be positive.");
            }

            this.name = name;
            this.maxHealth = maxHealth;
            this.currentHealth = maxHealth; // Start with full health
        }

        // --- Abstraction & Polymorphism ---
        // Abstract method: Defines a contract that all derived classes must implement.
        // The *how* of attacking is left to concrete classes.
        /// <summary>
        /// Abstract method for character attacks.
        /// Derived classes must provide their specific attack logic.
        /// Demonstrates Polymorphism.
        /// </summary>
        /// <returns>The amount of damage dealt by the attack.</returns>
        public abstract int Attack();

        // --- Encapsulation & Common Logic ---
        // Concrete method: Implemented in the base class, shared by all derived classes.
        /// <summary>
        /// Reduces the character's health based on incoming damage.
        /// Demonstrates Encapsulation by controlling modification of internal state (health).
        /// </summary>
        /// <param name="damage">The amount of damage taken.</param>
        public void TakeDamage(int damage)
        {
            // Basic validation
            if (damage < 0)
            {
                // Or you could throw an exception depending on requirements
                damage = 0; // Cannot take negative damage (healing) via this method
            }

            currentHealth -= damage;

            // Ensure health doesn't go below zero
            if (currentHealth < 0)
            {
                currentHealth = 0;
            }
        }

        // Helper method to get health as a formatted string (optional but useful)
        public string GetHealthStatus()
        {
            return $"{Health}/{MaxHealth} HP";
        }

        // Override ToString for easy display in logs/UI (Polymorphism example)
        public override string ToString()
        {
            return $"{Name} ({GetHealthStatus()})";
        }
    }
}