using System;
using System.Collections.Generic;
using System.Diagnostics;
using StatemachineModule.States;
using UnityEngine;
using VContainer.Unity;

namespace StatemachineModule 
{
    public class GameStatemachine<T> : IStartable, IStatemachine where T : GameState
    {
        private readonly Dictionary<Type, T> _states;
        private T _currentState;

        public GameStatemachine(PressStartState pressStartState, GameStartState startGameState)
        {
            _states = new()
            {
                {typeof(PressStartState), pressStartState as T },
                {typeof(GameStartState), startGameState as T },
            };
            UnityEngine.Debug.Log("statemachine created");
        }
        public void Update()
        {
            if (_currentState != null)
            {
                _currentState.Update();
            }
        }
        private void InitStates()
        {
            foreach (var states in _states)
            {
                states.Value.InjectOwner(this);
            }
        }
        public bool ChangeState<T>() where T : GameState
        {
            if (_states.ContainsKey(typeof(T)))
            {
                _currentState?.Exit();
                _currentState = _states[typeof(T)];
                _currentState.Enter();
                return true;
            }
            return false;
        }

        public void Start()
        {
            InitStates();
            ChangeState<PressStartState>();
        }
    }
    
}