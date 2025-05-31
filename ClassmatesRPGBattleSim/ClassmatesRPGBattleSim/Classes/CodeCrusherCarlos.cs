using System;

namespace ClassmatesRPGBattleSim.Classes
{
    /// <summary>
    /// Derived class representing Code Crusher Carlos.
    /// Inherits from ClassFighter and implements its own Attack logic.
    /// Demonstrates Inheritance and Polymorphism.
    /// </summary>
    public class CodeCrusherCarlos : ClassFighter
    {
        // Code Crusher Carlos hits harder but maybe less predictably
        private const int MIN_DAMAGE = 5;
        private const int MAX_DAMAGE = 25; // Wider range, potentially higher max
        private const int BASE_HEALTH = 120; // A bit more health

        // Static Random instance
        private static readonly Random rand = new Random();


        /// <summary>
        /// Constructor for Code Crusher Carlos. Calls the base constructor.
        /// </summary>
        /// <param name="name">The specific name for this instance of Code Crusher Carlos.</param>
        public CodeCrusherCarlos(string name) : base(name, BASE_HEALTH)
        {
            // Can add unique initializations here if needed
        }

        /// <summary>
        /// Implements Code Crusher Carlos's specific attack logic.
        /// Overrides the abstract method from ClassFighter.
        /// Demonstrates Polymorphism.
        /// </summary>
        /// <returns>The calculated random damage.</returns>
        public override int Attack()
        {
            // Generate random damage within the defined range
            int damage = rand.Next(MIN_DAMAGE, MAX_DAMAGE + 1);
            return damage;
        }

        // Could add unique methods or properties here specific to CodeCrusherCarlos
        // e.g., public void RefactorCode() { /*...*/ }
    }
}
