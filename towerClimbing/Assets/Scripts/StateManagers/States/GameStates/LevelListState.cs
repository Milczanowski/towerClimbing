using Assets.Scripts.DataBases.Models;
using Assets.Scripts.GUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.StateManagers.States.GameStates
{
    class LevelListState:State
    {
        protected override IEnumerator Init()
        {
            ScreensManager.LevelList.LoadLevels(OnClick);
            ScreensManager.LevelList.gameObject.SetActive(true);
            return base.Init();
        }

        private void OnClick(Level obj)
        {
            GameEngines.GameEngine.SetLevel(obj);
            Parent.Activate<LoadGameState>();
        }

        protected override void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                Parent.Parent.Activate<MenuState>();

            base.Update();
        }

        protected override IEnumerator End()
        {
            ScreensManager.LevelList.gameObject.SetActive(false);
            ScreensManager.LevelList.UnLoadLevels();

            return base.End();
        }
    }
}
