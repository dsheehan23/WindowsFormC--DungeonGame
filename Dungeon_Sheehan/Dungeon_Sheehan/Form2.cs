using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Sheehan
{
    public partial class Form2 : Form
    {
        // Game variables
        List<Treasure> Game_Treasure = new List<Treasure>();
        List<Creature> Game_Creature = new List<Creature>();
        List<Room> Game_Rooms = new List<Room>();
        List<Player> Game_Players = new List<Player>();
        Random randomNumbers = new Random();
        int player_amount; // how many players
        int player_counter = 0; // keep track of player turns


        // Initialize a list of treasure objects.
        // Shuffle the list using The Fisher-Yates Shuffle
        private void InitializeTreasures()
        {
            Game_Treasure.Add(new SilverTreasure("Silver Forks", 670.00));
            Game_Treasure.Add(new SilverTreasure("Silver Teeth", 800.00));
            Game_Treasure.Add(new GoldTreasure("California Gold", 1500.00));
            Game_Treasure.Add(new GoldTreasure("Hidden Pirate Gold", 2000.00));
            Game_Treasure.Add(new BronzeTreasure("3rd Place Olympic Medals", 400.00));
            Game_Treasure.Add(new BronzeTreasure("Bronze Bars", 500.00));
            Game_Treasure.Add(new CashTreasure("Lost Wallet", 900.00));
            Game_Treasure.Add(new CashTreasure("Christmas Fund", 1000.00));
            Game_Treasure.Add(new JokeTreasure("Monopoly Money", 0.00));
            Game_Treasure.Add(new JokeTreasure("Coins Under Couch", 4.30));
            Game_Treasure.Add(new SilverTreasure("Silver Fillings", 690.00));
            Game_Treasure.Add(new SilverTreasure("Silver Tongues", 810.00));
            Game_Treasure.Add(new GoldTreasure("Highway Gold", 1600.00));
            Game_Treasure.Add(new GoldTreasure("River Gold", 2100.00));
            Game_Treasure.Add(new BronzeTreasure("Bronze Statue", 420.00));
            Game_Treasure.Add(new BronzeTreasure("Copper Pennies", 530.00));
            Game_Treasure.Add(new CashTreasure("College Fund", 1200.00));
            Game_Treasure.Add(new CashTreasure("Lost Savings", 1100.00));
            Game_Treasure.Add(new JokeTreasure("Baseball Cards", 25.00));
            Game_Treasure.Add(new JokeTreasure("Swag Bucks", 7.30));

            int n = Game_Treasure.Count;

            while (n > 1)
            {
                n--;
                int k = randomNumbers.Next(n + 1);
                Treasure TempTreasure = Game_Treasure[k];
                Game_Treasure[k] = Game_Treasure[n];
                Game_Treasure[n] = TempTreasure;
            }  
        }

        // Initialize a list of creature objects.
        // Shuffle the list using The Fisher-Yates Shuffle
        private void InitializeCreatures()
        {
            Game_Creature.Add(new GhoulCreature("Ghost", 10));
            Game_Creature.Add(new GhoulCreature("Shawdow", 12));
            Game_Creature.Add(new GremlinCreature("School Bus Clinger", 15));
            Game_Creature.Add(new GremlinCreature("Front Yard Knome", 5));
            Game_Creature.Add(new KrampusCreature("Anti Christmas", 7));
            Game_Creature.Add(new KrampusCreature("Child Terrorizer", 13));
            Game_Creature.Add(new LordZeddCreature("Rito", 14));
            Game_Creature.Add(new LordZeddCreature("Scorpio", 18));
            Game_Creature.Add(new PokemonCreature("Mewtew", 20));
            Game_Creature.Add(new PokemonCreature("Sandshrew", 3));
            Game_Creature.Add(new GhoulCreature("Mummy", 8));
            Game_Creature.Add(new GhoulCreature("Frankenstein", 11));
            Game_Creature.Add(new GremlinCreature("Closet Monster", 14));
            Game_Creature.Add(new GremlinCreature("Yellow Eyes", 4));
            Game_Creature.Add(new KrampusCreature("Grinch", 8));
            Game_Creature.Add(new KrampusCreature("Rabid Rudolph", 14));
            Game_Creature.Add(new LordZeddCreature("Goldar", 13));
            Game_Creature.Add(new LordZeddCreature("Finster", 12));
            Game_Creature.Add(new PokemonCreature("Bulbasaur", 14));
            Game_Creature.Add(new PokemonCreature("Charzard", 22));

            int n = Game_Creature.Count;

            while (n > 1)
            {
                n--;
                int k = randomNumbers.Next(n + 1);
                Creature TempCreature = Game_Creature[k];
                Game_Creature[k] = Game_Creature[n];
                Game_Creature[n] = TempCreature;
            }  
        }

        // Initialize list of room objects with shuffled treasure and creature objects from respective lists
        private void InitializeRooms()
        {
            for (int i = 0; i < 20; ++i)
            {
                Game_Rooms.Add(new Room(Game_Treasure[i], Game_Creature[i]));
            }
        }

        // Initialize Game Buttons with Tags, used so that each button will be unique to a single object in room list
        private void InitializeButtons()
        {
            B1.Tag = 0;
            B2.Tag = 1;
            B3.Tag = 2;
            B4.Tag = 3;
            B5.Tag = 4;
            B6.Tag = 5;
            B7.Tag = 6;
            B8.Tag = 7;
            B9.Tag = 8;
            B10.Tag = 9;
            B11.Tag = 10;
            B12.Tag = 11;
            B13.Tag = 12;
            B14.Tag = 13;
            B15.Tag = 14;
            B16.Tag = 15;
            B17.Tag = 16;
            B18.Tag = 17;
            B19.Tag = 18;
            B20.Tag = 19;
        }

        // Check for end of game by checking to see if the amount of buttons disabled is 20,
        // which would be the whole gameboard. I used a try catch to bypass controls that are not buttons.
        // Returns true if the game is over.
        private bool CheckGameOver()
        {
            int amount_disabled = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button but = (Button)c;
                    if (but.Enabled == false)
                    {
                        ++amount_disabled;
                    }
                }
                catch { }
            }

            if (amount_disabled == 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Loops through the game players and sets the maximum player to the temporary player object
        // A message is displayed showing the game winner and amount of total treasure.
        private void DetermineWinner()
        {
            double max = 0;
            Player MaxPlayer = new Player("");
            foreach (var G in Game_Players)
            {
                if (G.GetTotalTreasureAmount() > max)
                {
                    max = G.GetTotalTreasureAmount();
                    MaxPlayer = G;
                }
            }

            MessageBox.Show(String.Format("{0} is the Game Winner with {1:C}.", MaxPlayer, max));
        }

        // Constructor for form 2. Player list from form 1 is passed in.
        // Form 2's Game_Players list is set to this, and player amount holds the total number of players.
        public Form2(List<Player> gmplyr)
        {
            InitializeComponent();
            Game_Players = gmplyr;
            player_amount = Game_Players.Count();

        }

        // When selected in the top menu bar, the running application will close
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // When the form loads, the object lists are initialized, buttons are initialized, and player names are displayed
        // on their labels.
        private void Form2_Load(object sender, EventArgs e)
        {
            // Initialize lists of creature and treasure objects
            InitializeCreatures();
            InitializeTreasures();
            InitializeRooms();
            InitializeButtons();
            Display_Player();
        }

        // All game activities occur when button is clicked. This function uses tags to work for all 20 buttons.
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            MessageBox.Show(Game_Rooms[(int)b.Tag].Room_Creature.ToString()); // Show what the room has
            MessageBox.Show("Rolling Di to attack Creature..."); // Show what you are doing
            
            // Roll a pair of di for attack
            int Dice1 = randomNumbers.Next(1, 7);
            int Dice2 = randomNumbers.Next(1, 7);
            int attack = Dice1 + Dice2;
            Game_Rooms[(int)b.Tag].Creature_Fight(attack); // Attack creature that corresponds to your button's room

            MessageBox.Show( String.Format("{0} attacked with {1} points!",Game_Players[player_counter], attack)); // show what the player's attack was

            if (Game_Rooms[(int)b.Tag].Room_Creature.Creature_Health <= 0) // creature defeated
            {
                MessageBox.Show(String.Format("{0} beat the creature and plundered the treasure! {1}", Game_Players[player_counter], Game_Rooms[(int)b.Tag].Room_Treasure)); // Display win and what the win was
                Game_Players[player_counter].SetTreasure_List(Game_Rooms[(int)b.Tag].Room_Treasure); // add the room winnings to the player's treasure list
                b.Enabled = false; // disable button
            }
            else
            {
                    MessageBox.Show(String.Format("{0} could not defeat the creature! The room remains open. The next player is up.", Game_Players[player_counter])); // show that the fight was lost
                    ++player_counter; // increment to next player
                    
                    // Start the list over if all the players have been run through
                    if (player_counter == player_amount)
                    {
                        player_counter = 0;
                    }
            }

            // Update the treasure list and total amount displays.
            Display_Treasure_List();
            Display_Total_Treasure();

            bool Over = CheckGameOver();

            // If the game has ended, call function to show winner
            if (Over)
            {
                DetermineWinner();
            }

            
        }

        // When the mouse pointer hovers over a room button, the current player will be displayed
        // and the player will be asked if they want to attack the room
        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = String.Format("{0}, Attack Here?", Game_Players[player_counter]);
            }
        }

        // The room button display will disappear after the mouse pointer leaves.
        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        // This will display Player Names for how many players there are on labels.
        // The try catch avoids error when there are not 4 players.
        private void Display_Player()
        {
            try
            {
                Player1.Text = Game_Players[0].ToString();
            }
            catch { }
            try
            {
                Player2.Text = Game_Players[1].ToString();
            }
            catch { }
            try
            {
                Player3.Text = Game_Players[2].ToString();
            }
            catch { }
            try
            {
                Player4.Text = Game_Players[3].ToString();
            }
            catch { }
        }

        // This will display Player Treasure List items for how many players there are on labels.
        // The try catch avoids error when there are not 4 players.
        private void Display_Treasure_List()
        {
            try
            {
                TreasureList1.Text = Game_Players[0].DisplayTreasure_List();
            }
            catch { }
            try
            {
                TreasureList2.Text = Game_Players[1].DisplayTreasure_List();
            }
            catch { }
            try
            {
                TreasureList3.Text = Game_Players[2].DisplayTreasure_List();
            }
            catch { }
            try
            {
                TreasureList4.Text = Game_Players[3].DisplayTreasure_List();
            }
            catch { }
        }
        
        // This will display total player treasure for how many players there are on labels.
        // The try catch avoids error when there are not 4 players.
        private void Display_Total_Treasure()
        {
            try
            {
                TreasureTotal1.Text = String.Format("{0:C", Game_Players[0].GetTotalTreasureAmount());
            }
            catch { }
            try
            {
                TreasureTotal2.Text = String.Format("{0:C", Game_Players[1].GetTotalTreasureAmount());
            }
            catch { }
            try
            {
                TreasureTotal3.Text = String.Format("{0:C", Game_Players[2].GetTotalTreasureAmount());
            }
            catch { }
            try
            {
                TreasureTotal4.Text = String.Format("{0:C", Game_Players[3].GetTotalTreasureAmount());
            }
            catch { }
        }

        // Starts a new Game of Dungeon with your current players, resetting fields
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear and reinitialize Treasure and Creature lists to remix and restore creature health, pass to rooms
            Game_Treasure.Clear();
            Game_Creature.Clear();
            Game_Rooms.Clear();

            InitializeCreatures();
            InitializeTreasures();
            InitializeRooms();

            // Enable buttons that have been disabled, using try catch to bypass controls that are not buttons
            foreach (Control c in Controls)
            {
                try
                {
                    Button but = (Button)c;
                    if (but.Enabled == false)
                    {
                        but.Enabled = true;
                    }
                }
                catch { }
            }

            // Delete game player treasure lists and redisplay empty values
            foreach (var element in Game_Players)
            {
                element.DeleteTreasureList();
            }

            Display_Treasure_List();
            Display_Total_Treasure();
        }

        // About option in menu, shows what to do on this form. 
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on an open room when your name is displayed to play the game.", "About Dungeon");
        }
    }
}
