using UnityEngine;

namespace ScoreModule 
{
    public class ScoreController : MonoBehaviour
    {
        public ScoreModel Model { get; private set; }
        private ScoreView view;

        public void Construct(ScoreModel model, ScoreView view)
        {
            Model = model;
            this.view = view;

            Model.OnScoreChange += InvokeUpdateScoreLabel;
        }

        public void InvokeUpdateScoreLabel()
        {
            view.UpdateScoreLabel(Model.Score);
        }
    }
}