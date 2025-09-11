using LevelGeneratorModule;
using ObstacleModule;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlayerModule
{
    public class PlayerView : MonoBehaviour
    {
        private Rigidbody2D playerRB;
        private Camera playerCamera;

        void Start()
        {
            playerRB = GetComponent<Rigidbody2D>();
            playerCamera = Camera.main;
        }

        void Update()
        {
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