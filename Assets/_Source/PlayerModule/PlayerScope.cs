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
            builder.RegisterInstance(Camera.main);

            builder.Register<PlayerModel>(Lifetime.Singleton);

            builder.RegisterComponentInHierarchy<PlayerView>();
            builder.RegisterComponentInHierarchy<PlayerController>();
            builder.RegisterComponentInHierarchy<PlayerCollider>();
            builder.RegisterComponentInHierarchy<Rigidbody2D>();
        }
    }
}