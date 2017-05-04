using Assets.Scripts.GUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.StateManagers.States.GameStates
{
    class ExitGameState: State
    {
        protected override IEnumerator Init()
        {
            Time.timeScale = 0;

            ScreensManager.ExitGame.gameObject.SetActive(true);
            ScreensManager.ExitGame.RemoveAllListeners();
            ScreensManager.ExitGame.NoButton.onClick.AddListener(OnNoClick);
            ScreensManager.ExitGame.YesButton.onClick.AddListener(OnYesClick);


            return base.Init();
        }

        private void OnYesClick()
        {
            Parent.Parent.Activate<MenuState>();
        }

        private void OnNoClick()
        {
            Parent.Activate<RunGameState>();
        }

        protected override IEnumerator End()
        {
            ScreensManager.ExitGame.gameObject.SetActive(false);
            Time.timeScale = 1;

            return base.End();
        }

    }
}
