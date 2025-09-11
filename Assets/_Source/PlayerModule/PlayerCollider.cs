using LevelGeneratorModule;
using ObstacleModule;
using ScoreModule;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlayerModule 
{
    public class PlayerCollider : MonoBehaviour
    {
        [SerializeField] private ScoreController scoreController;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.TryGetComponent(out Obstacle _))
            {
                SceneManager.LoadScene("Game");
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out LevelSectionGeneratorTrigger trigger))
            {
                trigger.InvokeLevelSectionGenerator();
            }
            else if (collision.TryGetComponent(out Coin coin))
            {
                scoreController.Model.Score += coin.Value;
                Destroy(coin.gameObject);
            }
        }
    }
}