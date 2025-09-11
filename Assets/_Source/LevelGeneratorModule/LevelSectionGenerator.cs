using System.Collections.Generic;
using UnityEngine;
using VContainer;

namespace LevelGeneratorModule 
{
    public class LevelSectionGenerator : MonoBehaviour
    {
        private List<LevelSection> levelSectionList;
        private Transform startingPosition;
        private const float SPAWNING_INTERVAL = 17.8f;
        private Vector3 spawningPos;

        [Inject]
        public void Construct(List<LevelSection> levelSectionList, Transform startingPosition)
        {
            this.levelSectionList = levelSectionList;
            this.startingPosition = startingPosition;

            spawningPos = this.startingPosition.position;
            spawningPos.x += SPAWNING_INTERVAL;
        }

        public void GenerateLevelSection()
        {
            int index = Random.Range(0, levelSectionList.Count);
            GameObject levelSection = Instantiate(levelSectionList[index].gameObject, spawningPos, Quaternion.identity);
            spawningPos.x += SPAWNING_INTERVAL;
        }
    }
}