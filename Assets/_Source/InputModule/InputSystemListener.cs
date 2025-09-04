using PlayerModule;
using UnityEngine;
using UnityEngine.InputSystem;

namespace InputModule 
{
    public class InputSystemListener : MonoBehaviour
    {
        [SerializeField] private PlayerController playerController;
        private PlayerInput playerInput;

        void Start()
        {
            playerInput = new();
            playerInput.Default.Enable();

            playerInput.Default.Jump.performed += AddVerticalVelocity;
        }

        void OnDestroy()
        {
            playerInput.Default.Disable();

            playerInput.Default.Jump.performed -= AddVerticalVelocity;
        }

        public void AddVerticalVelocity(InputAction.CallbackContext context)
        {
            playerController.InvokeAddVerticalVelocity();
        }
    }
}