using System;
using UnityEngine;

namespace PlayerModule 
{
    [CreateAssetMenu(fileName = "PlayerStatsSO", menuName = "Scriptable Objects/Create new Player Stats SO")]
    public class PlayerStats : ScriptableObject
    {
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public float JumpVelocity { get; private set; }
    }
}