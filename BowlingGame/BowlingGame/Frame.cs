using System;

namespace BowlingGame
{
    public abstract class Frame
    {
        readonly int firstPin_;
        readonly int secondPin_;

        protected Frame(int firstPin, int secondPin)
        {
            firstPin_ = firstPin;
            secondPin_ = secondPin;
        }
        public static Frame Roll(int firstRoll, int secondRoll)
        {
            /*
             * for future functionality
            if (firstRoll == 10) {
                return new Strike(firstRoll, secondRoll);
            }
            
            if (firstRoll + secondRoll == 10) {
                return new Spare(firstRoll, secondRoll);
            }*/

            return new CurrentFrame(firstRoll, secondRoll);
        }

        abstract public int FrameScore();
    }
}