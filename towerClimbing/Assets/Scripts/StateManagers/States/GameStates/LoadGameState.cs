using Assets.Scripts.GUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.StateManagers.States.GameStates
{
    class LoadGameState:State
    {
        protected override IEnumerator Init()
        {
            ScreensManager.LoadingPanel.gameObject.SetActive(true);

            yield return GameEngines.GameEngine.LoadLevel(OnFinish, ScreensManager.LoadingPanel.OnProgress);
            yield return base.Init();
        }

        private void OnFinish()
        {
            Parent.Activate<RunGameState>();
        }

        protected override IEnumerator End()
        {
            ScreensManager.LoadingPanel.gameObject.SetActive(false);

            yield return base.End();
        }

    }
}
