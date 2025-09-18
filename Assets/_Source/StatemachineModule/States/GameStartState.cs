using TMPro;
using UnityEngine;

namespace StatemachineModule.States 
{
    public class GameStartState : GameState
    {
        private readonly TextMeshProUGUI startLabel;

        public GameStartState(TextMeshProUGUI startLabel)
        {
            this.startLabel = startLabel;
        }

        public override void Enter()
        {
            startLabel.text = "";
            Time.timeScale = 1.0f;
        }
    }
}