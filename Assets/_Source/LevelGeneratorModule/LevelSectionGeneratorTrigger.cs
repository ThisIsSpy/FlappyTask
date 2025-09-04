using PlayerModule;
using UnityEngine;

namespace LevelGeneratorModule 
{
    public class LevelSectionGeneratorTrigger : MonoBehaviour
    {
        private LevelSectionGenerator generator;

        void Awake()
        {
            generator = FindFirstObjectByType<LevelSectionGenerator>();
        }

        public void InvokeLevelSectionGenerator()
        {
            generator.GenerateLevelSection();
        }
    }
}