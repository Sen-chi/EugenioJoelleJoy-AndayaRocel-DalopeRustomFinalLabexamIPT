// In a file named DebuggerDana.cs inside the 'Classes' folder

using System;

namespace ClassmatesRPGBattleSim.Classes
{
    /// <summary>
    /// Derived class representing Debugger Dana.
    /// Inherits from ClassFighter and implements its own Attack logic.
    /// Demonstrates Inheritance and Polymorphism.
    /// </summary>
    public class DebuggerDana : ClassFighter
    {
        // Debugger Dana has a consistent but maybe lower attack range
        private const int MIN_DAMAGE = 8;
        private const int MAX_DAMAGE = 15;
        private const int BASE_HEALTH = 100;

        // Static Random instance to avoid issues with rapid instantiation
        private static readonly Random rand = new Random();

        /// <summary>
        /// Constructor for Debugger Dana. Calls the base constructor.
        /// </summary>
        /// <param name="name">The specific name for this instance of Debugger Dana.</param>
        public DebuggerDana(string name) : base(name, BASE_HEALTH)
        {
            // Can add unique initializations here if needed
        }

        /// <summary>
        /// Implements Debugger Dana's specific attack logic.
        /// Overrides the abstract method from ClassFighter.
        /// Demonstrates Polymorphism.
        /// </summary>
        /// <returns>The calculated random damage.</returns>
        public override int Attack()
        {
            // Generate random damage within the defined range
            int damage = rand.Next(MIN_DAMAGE, MAX_DAMAGE + 1); // +1 because Next is exclusive of the upper bound
            return damage;
        }

        // Could add unique methods or properties here specific to DebuggerDana
        // e.g., public void FixSyntaxError() { /*...*/ }
    }
}