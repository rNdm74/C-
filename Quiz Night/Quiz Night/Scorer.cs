using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz_Night
{
    static class Scorer
    {
        private const int ADULT_CORRECT_SCORE   = 10;
        private const int ADULT_INCORRECT_SCORE = 1;
        private const int CHILD_CORRECT_SCORE   = 15;
        private const int CHILD_INCORRECT_SCORE = 0;

        public static int AdultScore(int correct, int incorrect)
        {
            return (correct * ADULT_CORRECT_SCORE) - (incorrect * ADULT_INCORRECT_SCORE);
        }

        public static int ChildScore(int correct, int incorrect)
        {
            return correct * CHILD_CORRECT_SCORE;
        }
    }
}
