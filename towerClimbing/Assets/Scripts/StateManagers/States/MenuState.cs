using Assets.Scripts.GUI;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.StateManagers.States
{
    class MenuState:State
    {
        protected override IEnumerator Init()
        {
            ScreensManager.Menu.StartButton.onClick.AddListener(OnStartButtonClick);
            ScreensManager.Menu.CreditsButton.onClick.AddListener(OnCreditsButtonClick);
            ScreensManager.Menu.OptionsButton.onClick.AddListener(OnOptionsButtonClick);
            ScreensManager.Menu.ExitButtons.onClick.AddListener(OnExitButtonClick);
            ScreensManager.Menu.gameObject.SetActive(true);

            return base.Init();
        }

        private void OnExitButtonClick()
        {
            Application.Quit();
        }

        private void OnOptionsButtonClick()
        {
            Parent.Activate<OptionsState>();
        }

        private void OnCreditsButtonClick()
        {
            Parent.Activate<CreditsState>();
        }

        private void OnStartButtonClick()
        {
            Parent.Activate<GameState>();
        }

        protected override IEnumerator End()
        {
            ScreensManager.Menu.gameObject.SetActive(false);
            return base.End();
        }
    }
}
