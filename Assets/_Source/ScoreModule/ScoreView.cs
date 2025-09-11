using TMPro;
using UnityEngine;
using VContainer;

namespace ScoreModule 
{
    public class ScoreView : MonoBehaviour
    {
        private TextMeshProUGUI scoreLabel;

        [Inject]
        public void Construct(TextMeshProUGUI scoreLabel)
        {
            this.scoreLabel = scoreLabel;
        }

        public void UpdateScoreLabel(int score)
        {
            scoreLabel.text = score.ToString();
        }
    }
}