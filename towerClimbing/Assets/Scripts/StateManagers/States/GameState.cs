using Assets.Scripts.GUI;
using Assets.Scripts.StateManagers.States.GameStates;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.StateManagers.States
{
    class GameState:State
    {
        protected override void InitStates()
        {
            AddState<LevelListState>(this);
            AddState<LoadGameState>(this);
            AddState<RunGameState>(this);
            AddState<ExitGameState>(this);
        }

        protected override IEnumerator Init()
        {
            Activate<LevelListState>();
            yield return base.Init();
        }

        protected override IEnumerator End()
        {
            yield return base.End();
        }
    }
}
