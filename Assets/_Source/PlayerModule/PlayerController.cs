using UnityEngine;
using VContainer;

namespace PlayerModule 
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerModel model;
        private PlayerView view;
        private bool isConstructed = false;

        [Inject]
        public void Construct(PlayerModel model, PlayerView view)
        {
            Debug.Log(model == null);
            this.model = model;
            this.view = view;
            isConstructed = true;
        }

        void Update()
        {
            if (!isConstructed) return;
            view.LinearMove(model.Speed);
        }

        public void InvokeAddVerticalVelocity()
        {
            view.AddVerticalVelocity(model.JumpVelocity);
        }
    }
}