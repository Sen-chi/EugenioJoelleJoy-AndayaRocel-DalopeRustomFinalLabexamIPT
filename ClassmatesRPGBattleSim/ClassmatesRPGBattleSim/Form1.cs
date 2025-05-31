// Ensure all necessary using directives are present
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassmatesRPGBattleSim.Classes;


namespace ClassmatesRPGBattleSim
{
    public partial class Form1 : Form
    {
        // --- Add the class-level Random instance (from Step 4) ---
        // This ensures we use the same Random generator throughout the form's lifetime.
        private Random battleRandom = new Random();


        public Form1()
        {
            InitializeComponent();
            // --- Call the method to populate character types on form load ---
            PopulateCharacterTypes();
        }

        /// <summary>
        /// Populates the ComboBoxes with available character types.
        /// (Added from Step 4)
        /// </summary>
        private void PopulateCharacterTypes()
        {
            // Add the names of your derived classes to the ComboBoxes
            // These strings will be used to create instances later in CreateCharacter().
            // Make sure these strings match exactly the cases in CreateCharacter().
            cboCharacterType1.Items.Add("Debugger Dana");
            cboCharacterType1.Items.Add("Code Crusher Carlos");
            // Add more types here as you create them (e.g., cboCharacterType1.Items.Add("NewCharacterType");)

            cboCharacterType2.Items.Add("Debugger Dana");
            cboCharacterType2.Items.Add("Code Crusher Carlos");
            // Add more types here for the second player
        }


        // --- This is the event handler for your Start Battle button ---
        // Its CONTENT has been replaced with the battle logic from Step 4.
        /// <summary>
        /// Handles the "Start Battle!" button click event.
        /// Implements the core battle logic, character creation, and UI updates.
        /// Also includes Exception Handling.
        /// (Logic from Step 4)
        /// </summary>
        private void btnStartBattle_Click(object sender, EventArgs e)
        {
          
            try
            {
                // Validate user input: Check if names are entered and character types are selected
                if (string.IsNullOrWhiteSpace(txtName1.Text) || string.IsNullOrWhiteSpace(txtName2.Text))
                {
                    // Throw an ArgumentException if input is missing, which will be caught below
                    throw new ArgumentException("Please enter names for both players.");
                }

                if (cboCharacterType1.SelectedItem == null || cboCharacterType2.SelectedItem == null)
                {
                    // Throw an ArgumentException if character types are not selected
                    throw new ArgumentException("Please select a character type for both players.");
                }

                // Clear previous battle results and reset UI elements
                lstBattleLog.Items.Clear(); // Clear the battle log
                lblWinner.Text = ""; // Clear the winner label
                lblHealth1.Text = "- HP"; // Reset health display
                lblHealth2.Text = "- HP"; // Reset health display
                // Optional: Disable button or change cursor while battle runs if it were long

                // --- CHARACTER CREATION (Step 4.1) ---
                // Use the helper method to create character instances based on user selection.
                // This demonstrates Polymorphism - player1 and player2 are ClassFighter references,
                // but they will hold instances of the derived classes (DebuggerDana or CodeCrusherCarlos).
                ClassFighter player1 = CreateCharacter(cboCharacterType1.SelectedItem.ToString(), txtName1.Text);
                ClassFighter player2 = CreateCharacter(cboCharacterType2.SelectedItem.ToString(), txtName2.Text);

                // Update initial health displays on the UI using the characters' properties
                lblHealth1.Text = player1.GetHealthStatus();
                lblHealth2.Text = player2.GetHealthStatus();

                // Add a starting message to the battle log
                lstBattleLog.Items.Add($"--- Battle Start: {player1.Name} ({cboCharacterType1.SelectedItem}) vs {player2.Name} ({cboCharacterType2.SelectedItem}) ---");
                lstBattleLog.Items.Add(""); // Add a blank line for spacing in the log

                // --- TURN-BASED BATTLE LOGIC (Step 4.2 - 4.4) ---
                int turn = 1; // Initialize turn counter

                // The battle continues as long as both players are alive
                while (player1.Health > 0 && player2.Health > 0)
                {
                    lstBattleLog.Items.Add($"--- Turn {turn} ---"); // Log the current turn

                    // Player 1's turn to attack Player 2
                    // Check if player 1 is still alive before attacking (important if Player 2's last attack defeated Player 1)
                    if (player1.Health > 0)
                    {
                        // --- Polymorphism in Action ---
                        // Calling Attack() executes the specific Attack method of the actual object type (Dana's or Carlos's).
                        // Calling TakeDamage() executes the base class's TakeDamage method.
                        int p1Damage = player1.Attack(); // Get damage from player 1's specific attack logic
                        player2.TakeDamage(p1Damage);    // Apply damage to player 2 using the common method

                        // Log the action and update player 2's health display
                        lstBattleLog.Items.Add($"{player1.Name} attacks {player2.Name} for {p1Damage} damage.");
                        lblHealth2.Text = player2.GetHealthStatus(); // Update UI

                        // Check if Player 2 was defeated after taking damage
                        if (player2.Health <= 0)
                        {
                            lstBattleLog.Items.Add($"{player2.Name} has been defeated!");
                            break; // Exit the loop as the battle is over
                        }
                    }

                    // Player 2's turn to attack Player 1 (only if Player 2 is still alive)
                    if (player2.Health > 0) // Check health again before Player 2 attacks
                    {
                        // --- Polymorphism in Action ---
                        int p2Damage = player2.Attack(); // Get damage from player 2's specific attack logic
                        player1.TakeDamage(p2Damage);    // Apply damage to player 1

                        // Log the action and update player 1's health display
                        lstBattleLog.Items.Add($"{player2.Name} attacks {player1.Name} for {p2Damage} damage.");
                        lblHealth1.Text = player1.GetHealthStatus(); // Update UI

                        // Check if Player 1 was defeated after taking damage
                        if (player1.Health <= 0)
                        {
                            lstBattleLog.Items.Add($"{player1.Name} has been defeated!");
                            break; // Exit the loop as the battle is over
                        }
                    }

                    lstBattleLog.Items.Add(""); // Add a blank line for better readability between turns
                    turn++; // Increment turn counter

                    // Optional: Use Application.DoEvents() here if battles are very long and you need
                    // the UI to update mid-loop. For short battles, it's usually not necessary
                    // and can sometimes cause unexpected behavior if not used carefully.
                    // Application.DoEvents();
                }

                // --- Determine and Display Winner (Step 4.5) ---
                lstBattleLog.Items.Add("--- Battle End ---"); // Log battle end

                // Check health to see who was defeated (health <= 0) or if it was a tie
                if (player1.Health <= 0 && player2.Health <= 0)
                {
                    lblWinner.Text = "It's a tie!"; // Unlikely with this logic, but possible
                    lstBattleLog.Items.Add("Both players were defeated!");
                }
                else if (player1.Health <= 0) // If player 1's health is 0 or less, player 2 wins
                {
                    lblWinner.Text = $"{player2.Name} Wins!"; // Display winner on UI
                    lstBattleLog.Items.Add($"{player2.Name} is the winner!"); // Log winner
                }
                else // Otherwise, player 1 wins
                {
                    lblWinner.Text = $"{player1.Name} Wins!"; // Display winner on UI
                    lstBattleLog.Items.Add($"{player1.Name} is the winner!"); // Log winner
                }

                // Automatically scroll the ListBox to the bottom to see the latest entries
                lstBattleLog.SelectedIndex = lstBattleLog.Items.Count - 1;
                lstBattleLog.ClearSelected(); // Deselect the last item if desired


            }
            // --- Catch common exceptions (Step 5) ---
            // Catch specific ArgumentException for input validation errors
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Catch any other unexpected exceptions
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // In a real application, you might also log the full exception details (ex.ToString())
            }
        }

        /// <summary>
        /// Factory-like method to create character instances based on the selected type string.
        /// This uses the name selected in the ComboBoxes to decide which concrete class to instantiate.
        /// (Added from Step 4)
        /// </summary>
        /// <param name="characterType">The string name representing the character type (e.g., "Debugger Dana").</param>
        /// <param name="name">The desired name for this specific character instance.</param>
        /// <returns>An instance of a class that inherits from ClassFighter.</returns>
        /// <exception cref="ArgumentException">Thrown if the provided character type string doesn't match a known class.</exception>
        private ClassFighter CreateCharacter(string characterType, string name)
        {
            // Use a switch statement to create the correct derived class instance
            switch (characterType)
            {
                case "Debugger Dana":
                    return new DebuggerDana(name); // Creates an instance of DebuggerDana
                case "Code Crusher Carlos":
                    return new CodeCrusherCarlos(name); // Creates an instance of CodeCrusherCarlos
                // Add more cases here for any other character types you create
                // For example:
                // case "Quiz Master Quincy":
                //     return new QuizMasterQuincy(name);

                default:
                    // This case should ideally not be hit if the ComboBox is populated correctly,
                    // but it acts as a safeguard.
                    throw new ArgumentException($"Unknown character type: {characterType}");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


     
    }
}
