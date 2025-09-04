using PlayerModule;
using UnityEngine;

namespace CoreModule 
{
    public class Bootstrapper : MonoBehaviour
    {
        [Header("Player Stuff")]
        private PlayerModel playerModel;
        [SerializeField] private PlayerView playerView;
        [SerializeField] private PlayerController playerController;
        [SerializeField] private float initialPlayerSpeed;
        [SerializeField] private float initialPlayerJumpVelocity;

        void Start()
        {
            playerModel = new PlayerModel(initialPlayerSpeed, initialPlayerJumpVelocity);
            playerController.Construct(playerModel, playerView);
        }
    }
}