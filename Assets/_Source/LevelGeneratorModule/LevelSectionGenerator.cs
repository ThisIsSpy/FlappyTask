using System.Collections.Generic;
using UnityEngine;

namespace LevelGeneratorModule 
{
    public class LevelSectionGenerator : MonoBehaviour
    {
        [SerializeField] private List<LevelSection> levelSectionList;
        [SerializeField] private Transform startingPosition;
        [SerializeField] private float spawningInterval;
        private Vector3 spawningPos;

        void Start()
        {
            spawningPos = startingPosition.position;
            spawningPos.x += spawningInterval;
            Debug.Log(spawningPos);
        }

        public void GenerateLevelSection()
        {
            int index = Random.Range(0, levelSectionList.Count);
            GameObject levelSection = Instantiate(levelSectionList[index].gameObject, spawningPos, Quaternion.identity);
            spawningPos.x += spawningInterval;
            Debug.Log("should have generate a section");
        }
    }
}