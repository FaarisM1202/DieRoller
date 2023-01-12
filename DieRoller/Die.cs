using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six-side die.
    /// </summary>
    public class Die
    {
        private static Random _rand;

        static Die()
        {
            _rand = new();
        }
        /// <summary>
        /// This will create the die to roll with to start
        /// the random number.
        /// </summary>
        public Die()
        {
            Roll();
        }

        // Current value from the user's roll.
        public byte FaceValue { get; private set; }

        // Check if the die is being held.
        public bool IsHeld { get; set; }

        // Roll the die(Set the value).

        /// <summary>
        /// Rolls the die and sets the value <see cref="FaceValue"/>
        /// to the number. If die is not held currently, return new number after.
        /// </summary>
        public byte Roll()
        {
            if(!IsHeld)
            {
                // Generate another random number.
                byte newValue = (byte)_rand.Next(1, 7);

                // Set it to the value.
                FaceValue = newValue;
            }         
            // Return new number
            return FaceValue;
        }
    }
}
