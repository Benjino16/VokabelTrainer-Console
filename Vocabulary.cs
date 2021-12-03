using System;
using System.Collections.Generic;
using System.Text;

namespace VokabelTrainer
{
    class Vocabulary
    {
        public string Word { get; set; }
        public string Translation { get; set; }
        public float Progress { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return "Word: " + Word + "      Translation: " + Translation + "      Progress: " + Progress;
        }
    }
}
