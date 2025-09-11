using TMPro;
using UnityEngine;

namespace ScoreModule 
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreLabel;

        public void UpdateScoreLabel(int score)
        {
            scoreLabel.text = score.ToString();
        }
    }
}