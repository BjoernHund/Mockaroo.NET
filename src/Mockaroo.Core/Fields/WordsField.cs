﻿namespace Gigobyte.Mockaroo.Fields
{
    public partial class WordsField
    {
        /// <summary>
        /// Gets or sets the minimum number of words to generate.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public virtual int Min { get; set; } = 10;

        /// <summary>
        /// Gets or sets the maximum number of words to generate.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public virtual int Max { get; set; } = 20;

        
    }
}