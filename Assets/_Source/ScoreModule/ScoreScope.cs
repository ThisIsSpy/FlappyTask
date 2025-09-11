using TMPro;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ScoreModule 
{
    public class ScoreScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<ScoreModel>(Lifetime.Singleton);
            builder.RegisterComponentInHierarchy<ScoreView>();
            builder.RegisterComponentInHierarchy<ScoreController>();
            builder.RegisterComponentInHierarchy<TextMeshProUGUI>();
        }
    }
}