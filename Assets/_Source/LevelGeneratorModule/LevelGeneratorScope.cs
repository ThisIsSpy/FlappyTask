using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace LevelGeneratorModule 
{
    public class LevelGeneratorScope : LifetimeScope
    {
        [SerializeField] private List<LevelSection> levelSectionList;
        [SerializeField] private Transform startingPos;
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponentInHierarchy<LevelSectionGenerator>();
            builder.RegisterInstance(levelSectionList);
            builder.RegisterInstance(startingPos);
        }
    }
}