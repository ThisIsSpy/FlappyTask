using UnityEngine;

namespace ScoreModule 
{
    public class Coin : MonoBehaviour
    {
        [field: SerializeField] public int Value { get; private set; }
    }
}