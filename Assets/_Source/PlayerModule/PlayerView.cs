using LevelGeneratorModule;
using ObstacleModule;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer;

namespace PlayerModule
{
    public class PlayerView : MonoBehaviour
    {
        private Rigidbody2D playerRB;
        private Camera playerCamera;
        private bool isConstructed = false;

        [Inject]
        public void Construct(Rigidbody2D playerRB, Camera playerCamera)
        {
            this.playerRB = playerRB;
            this.playerCamera = playerCamera;
            isConstructed = true;
        }

        void Update()
        {
            if (!isConstructed) return;
            playerCamera.transform.position = new(transform.position.x + 5, 0, -10);
            playerCamera.transform.eulerAngles = Vector3.zero;
        }

        public void LinearMove(float speed)
        {
            playerRB.linearVelocityX = speed;
        }

        public void AddVerticalVelocity(float speed)
        {
            playerRB.linearVelocityY += speed;
        }
    }
}