using Assets.Scripts.StateManagers.States;
using System.Collections;

namespace Assets.Scripts.StateManagers
{
    class Root : State
    {
        protected override void InitStates()
        {
            AddState<InitState>(this);
            AddState<MenuState>(this);
            AddState<CreditsState>(this);
            AddState<GameState>(this);
            AddState<OptionsState>(this);

            base.InitStates();
        }

        protected internal IEnumerator Enable()
        {
            yield return _Activate<InitState>();
            yield return null;
        }

        protected internal void _Update()
        {
            Update();
        }
    }
}
