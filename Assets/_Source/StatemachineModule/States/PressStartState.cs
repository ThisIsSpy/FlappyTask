using TMPro;
using UnityEngine;

namespace StatemachineModule.States
{

    public class PressStartState : GameState
    {
        private readonly TextMeshProUGUI startLabel;

        public PressStartState(TextMeshProUGUI startLabel)
        {
            this.startLabel = startLabel;
        }

        public override void Enter()
        {
            startLabel.text = "Press Space to start";
            Time.timeScale = 0f;
        }
    }

}