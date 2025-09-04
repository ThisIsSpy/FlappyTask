using UnityEngine;

namespace UtilityModule 
{
    public class LockAxisRotation : MonoBehaviour
    {
        [SerializeField] private bool lockXRotation;
        [SerializeField] private bool lockYRotation;
        [SerializeField] private bool lockZRotation;
        private float originalX;
        private float originalY;
        private float originalZ;

        void Start()
        {
            originalX = transform.eulerAngles.x;
            originalY = transform.eulerAngles.y;
            originalZ = transform.eulerAngles.z;
        }

        private void Update()
        {
            Vector3 lockedRot = transform.eulerAngles;
            if(lockXRotation) lockedRot.x = originalX;
            if(lockYRotation) lockedRot.y = originalY;
            if(lockZRotation) lockedRot.z = originalZ;
            transform.eulerAngles = lockedRot;
        }
    }
}