using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synthesizer
{
    public class PianoKey
    {
        public string NoteName;
        public double frequency;
        public PianoKey(string _noteName, double _frequency)
        {
            NoteName = _noteName;
            frequency = _frequency;
        }
    }
}
