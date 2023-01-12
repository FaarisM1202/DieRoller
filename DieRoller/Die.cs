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
        // Current value from the user's roll.
        public byte FaceValue { get; set; }

        // Check if the die is being held.
        public bool IsHeld { get; set; }

        // Roll the die(Set the value).

        /// <summary>
        /// Rolls the die and sets the value <see cref="FaceValue"/>
        /// to the number.
        /// </summary>
        public byte Roll()
        {
            // Generate a random number.

            // Set it to the value.

            // Return new number
            throw new NotImplementedException();
        }
    }
}
