using UnityEngine;

namespace ScoreModule 
{
    public class ScoreModel
    {
        private int score;

        public event System.Action OnScoreChange;

        public int Score 
        { 
            get { return score; } 
            set 
            { 
                score = Mathf.Clamp(value, 0, int.MaxValue);
                OnScoreChange?.Invoke();
            }
        }

        public ScoreModel()
        {
            Score = 0;
        }
    }
}