using System;
using System.Collections.Generic;

namespace BowlingGame
{
    class BowlingGame
    {
        private List<Frame> frames_ = new List<Frame>();
        private static readonly Random getRandom = new Random();
        private const int min_ = 0;
        private const int max_ = 10;
        private int count = 0;
        private int currentScore = 0;
        private bool isLastTurn = false;
        private bool gameOver = false;
        private bool cheatActivated = false;
        private bool loseActivated = false;
        private string tempStr = "";
        private int firstRoll = 0;
        private int secondRoll = 0;
        private int totalScore = 0;

        public void RollBall()
        {
            if (!GameOver())
            {
                if (cheatActivated || loseActivated)
                {
                    firstRoll = cheatActivated ? 10 : 0;
                } else
                {
                    firstRoll = GetRandomNumber(min_, max_);
                    secondRoll = (firstRoll == 10) ? 0 : GetRandomNumber(min_, (max_ - firstRoll));
                }
                if (LastTurn())
                {
                        if (firstRoll + secondRoll == 10)
                        {
                            Add(Frame.Roll((firstRoll + InitiateBonus()), secondRoll));
                        } else
                        {
                            Add(Frame.Roll(firstRoll, secondRoll));
                        }
                } else
                {
                        Add(Frame.Roll(firstRoll, secondRoll));
                }
                
                Update(firstRoll, secondRoll);
            }
        }

        private int InitiateBonus()
        {
            int bonusRoll;
            if (!cheatActivated)
            {
                bonusRoll = GetRandomNumber(min_, max_);
            } else
            {
                bonusRoll = 10;
            }
            tempStr = "\nYour bonus roll was: ";
            tempStr += bonusRoll.ToString();
            return bonusRoll;
        }

        public bool InitiateCheatMode()
        {
            cheatActivated = true;
            return cheatActivated;
        }

        public bool InitiateLoseMode()
        {
            loseActivated = true;
            return loseActivated;
        }

        private void Update(int first, int second)
        {
            currentScore = frames_[count].FrameScore();
            totalScore += frames_[count].FrameScore();
            ++count;
        }

        public string ThrowResults()
        {
            string result = "Your first throw was: ";
            result += firstRoll.ToString();
            if (firstRoll != 10)
            {
                result += "\nYour second throw was: ";
                result += secondRoll.ToString();
            }
            result += tempStr;
            return result;
        }

        public int TotalScore()
        {
            return totalScore;
        }

        public int CurrentScore()
        {
            return currentScore;
        }

        private static int GetRandomNumber(int min, int max)
        {
            return getRandom.Next(min, (max+1));
        }

        private void Add(Frame newFrame)
        {
            frames_.Add(newFrame);
        }

        private bool LastTurn()
        {
            if (frames_.Count.Equals(9))
            {
                isLastTurn = true;
            }
            return isLastTurn;
        }

        public bool GameOver()
        {
            if (frames_.Count.Equals(10))
            {
                gameOver = true;
            
            }
            return gameOver;
        }

        public void StopGame()
        {
            if (GameOver())
            {
                Reset();
            }
        }

        private void Reset()
        {
            frames_.Clear();
            firstRoll = 0;
            secondRoll = 0;
            currentScore = 0;
            totalScore = 0;
            count = 0;
        }
    }
}
