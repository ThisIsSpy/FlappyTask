using UnityEngine;

namespace PlayerModule 
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerModel model;
        private PlayerView view;

        public void Construct(PlayerModel model, PlayerView view)
        {
            this.model = model;
            this.view = view;
        }

        void Update()
        {
            view.LinearMove(model.Speed);
        }

        public void InvokeAddVerticalVelocity()
        {
            view.AddVerticalVelocity(model.JumpVelocity);
        }
    }
}