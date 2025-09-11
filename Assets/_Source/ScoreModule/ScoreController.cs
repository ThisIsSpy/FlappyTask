using UnityEngine;
using VContainer;

namespace ScoreModule 
{
    public class ScoreController : MonoBehaviour
    {
        public ScoreModel Model { get; private set; }
        private ScoreView view;

        [Inject]
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

        void OnDestroy()
        {
            Model.OnScoreChange -= InvokeUpdateScoreLabel;
        }
    }
}