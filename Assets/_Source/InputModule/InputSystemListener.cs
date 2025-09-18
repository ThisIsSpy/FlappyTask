using PlayerModule;
using StatemachineModule;
using StatemachineModule.States;
using UnityEngine;
using UnityEngine.InputSystem;
using VContainer;
using VContainer.Unity;

namespace InputModule 
{
    public class InputSystemListener : MonoBehaviour, IStartable
    {
        private PlayerController playerController;
        private PlayerInput playerInput;
        private GameStatemachine<GameState> statemachine;

        [Inject]
        public void Construct(PlayerController playerController, GameStatemachine<GameState> statemachine)
        {
            this.playerController = playerController;
            this.statemachine = statemachine;
            Debug.Log("");
        }

        public void Start()
        {
            playerInput = new();
            playerInput.Default.Enable();

            playerInput.Default.Jump.performed += AddVerticalVelocity;
            playerInput.Default.Jump.performed += StartGame;
        }

        void OnDestroy()
        {
            playerInput.Default.Disable();

            playerInput.Default.Jump.performed -= AddVerticalVelocity;
            playerInput.Default.Jump.performed -= StartGame;
        }

        public void AddVerticalVelocity(InputAction.CallbackContext context)
        {
            playerController.InvokeAddVerticalVelocity();
        }

        public void StartGame(InputAction.CallbackContext context)
        {
            statemachine.ChangeState<GameStartState>();
            playerInput.Default.Jump.performed -= StartGame;
        }
    }
}