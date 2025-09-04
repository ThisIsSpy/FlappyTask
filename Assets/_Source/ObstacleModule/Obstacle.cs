using System.Collections;
using UnityEngine;

namespace ObstacleModule 
{
    public class Obstacle : MonoBehaviour
    {
        [SerializeField] private bool isMoving;
        [SerializeField] private Direction direction;
        [SerializeField] private float speed;
        [SerializeField] private float cooldown;
        private Rigidbody2D rb;

        void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            if (isMoving) StartCoroutine(MovingCoroutine());
        }

        public IEnumerator MovingCoroutine()
        {
            if(direction == Direction.UpDown) rb.linearVelocityY = speed;
            else if (direction == Direction.LeftRight) rb.linearVelocityX = speed;
            yield return new WaitForSeconds(cooldown);

            if (direction == Direction.UpDown) rb.linearVelocityY = -speed;
            else if (direction == Direction.LeftRight) rb.linearVelocityX = -speed;
            yield return new WaitForSeconds(cooldown);

            StartCoroutine(MovingCoroutine());
        }
    }

    public enum Direction
    {
        UpDown,
        LeftRight
    }
}