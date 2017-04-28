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
            ScreensManager.GameGUI.gameObject.SetActive(true);

            yield return base.Init();
        }

        protected override IEnumerator End()
        {
            ScreensManager.GameGUI.gameObject.SetActive(false);

            yield return base.End();
        }

    }
}
