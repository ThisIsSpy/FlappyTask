using UnityEngine;

namespace PlayerModule
{
    public class PlayerModel
    {
        private float speed;
        private float jumpVelocity;

        public float Speed
        {
            get { return speed; }
            set { speed = Mathf.Clamp(value, 1, 100); }
        }

        public float JumpVelocity
        {
            get { return jumpVelocity; }
            set { jumpVelocity = Mathf.Clamp(value, 1, 100); }
        }

        public PlayerModel(PlayerStats playerStats)
        {
            Speed = playerStats.Speed;
            JumpVelocity = playerStats.JumpVelocity;
        }
    }
}