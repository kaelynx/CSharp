/* for future funtionality */

namespace BowlingGame
{
    class Strike : Frame
    {
        private readonly int firstRoll_;
        private readonly int secondRoll_;
        public Strike(int firstRoll, int secondRoll) : base(10, 0)
        {
            firstRoll_ = firstRoll;
            secondRoll_ = secondRoll;
        }

        override public int FrameScore()
        {
            int score = firstRoll_ + secondRoll_;
            return score;
        }

    }
}
