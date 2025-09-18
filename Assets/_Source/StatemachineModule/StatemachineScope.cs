using InputModule;
using StatemachineModule.States;
using TMPro;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace StatemachineModule 
{   
    public class StatemachineScope : LifetimeScope
    {
        [SerializeField] private TextMeshProUGUI startLabel;
        [SerializeField] private InputSystemListener listener;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(startLabel);
            builder.RegisterComponent(listener);

            builder.Register<PressStartState>(Lifetime.Singleton);
            builder.Register<GameStartState>(Lifetime.Singleton);
            builder.RegisterEntryPoint<GameStatemachine<GameState>>(Lifetime.Singleton).AsSelf();
        }
    }
}