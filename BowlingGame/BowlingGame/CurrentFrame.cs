using System;
namespace BowlingGame
{
    public class CurrentFrame : Frame
    {
        private readonly int firstRoll_;
        private readonly int secondRoll_;
        public CurrentFrame(int firstRoll, int secondRoll) : base(firstRoll, secondRoll)
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