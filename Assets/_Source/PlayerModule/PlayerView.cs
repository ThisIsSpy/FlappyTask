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

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.TryGetComponent(out Obstacle _))
            {
                SceneManager.LoadScene("Game");
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.TryGetComponent(out LevelSectionGeneratorTrigger trigger))
            {
                trigger.InvokeLevelSectionGenerator();
                Debug.Log("triggered");
            }
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