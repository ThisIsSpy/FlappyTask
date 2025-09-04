using System.Collections;
using UnityEngine;

namespace LevelGeneratorModule 
{
    public class LevelSection : MonoBehaviour
    {
        [SerializeField] private float destroyCountdown = 10f;
        void Awake()
        {
            Debug.Log("section awake");
            StartCoroutine(DestructionCoroutine());
        }

        void OnDestroy()
        {
            Debug.Log("section destroyed");
        }

        private IEnumerator DestructionCoroutine()
        {
            yield return new WaitForSeconds(destroyCountdown);
            Destroy(gameObject);
        }
    }
}