using System;

namespace zoo
{
    /// <summary>
    /// Class describing an elephant in a zoo
    /// </summary>
    public class Elephant
    {
        private int _weight;

        /// <summary>
        /// The weight of the elephant
        /// Measured in kilograms
        /// Pre-condition: <code>Weight >= 100</code>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">if weight &lt; 100</exception>
        public int Weight
        {
            get { return _weight; }
            set
            {
                if (value < 100) throw new ArgumentOutOfRangeException("weight", value, "Weight must be at least 100 kg");
                _weight = value;
                // HACK to be changed ...
            }
        }

        // TODO add Height property
    }
}
