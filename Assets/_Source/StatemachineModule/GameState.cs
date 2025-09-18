using UnityEngine;

namespace StatemachineModule 
{
    public abstract class GameState
    {
        protected IStatemachine Owner;
        public void InjectOwner(IStatemachine owner)
        {
            Owner = owner;
        }
        public virtual void Enter() { }
        public virtual void Update() { }
        public virtual void Exit() { }
    }
}