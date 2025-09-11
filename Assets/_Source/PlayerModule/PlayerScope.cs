using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace PlayerModule 
{
    public class PlayerScope : LifetimeScope
    {
        [SerializeField] private PlayerStats playerStats;
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(playerStats);
            builder.Register<PlayerModel>(Lifetime.Singleton);
            builder.RegisterComponentInHierarchy<PlayerView>();
            builder.RegisterComponentInHierarchy<PlayerController>();
        }
    }
}