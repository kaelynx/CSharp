/* for future functionality */
namespace BowlingGame
{
    class Spare : Frame
    {

        private readonly int firstRoll_;
        private readonly int secondRoll_;
        public Spare(int firstRoll, int secondRoll) : base(firstRoll, secondRoll)
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
