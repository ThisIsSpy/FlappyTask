using UnityEngine;

namespace UtilityModule 
{
    public class LockAxisMovement : MonoBehaviour
    {
        [SerializeField] private bool lockXMovement;
        [SerializeField] private bool lockYMovement;
        [SerializeField] private bool lockZMovement;
        private float originalX;
        private float originalY;
        private float originalZ;

        void Start()
        {
            originalX = transform.position.x;
            originalY = transform.position.y;
            originalZ = transform.position.z;
        }

        void Update()
        {
            Vector3 lockedPos = transform.position;
            if(lockXMovement) lockedPos.x = originalX;
            if(lockYMovement) lockedPos.y = originalY;
            if(lockZMovement) lockedPos.z = originalZ;
            transform.position = lockedPos;
        }
    }
}