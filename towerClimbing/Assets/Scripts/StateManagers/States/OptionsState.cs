using Assets.Scripts.GUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.StateManagers.States
{
    class OptionsState: State
    {
        protected override IEnumerator Init()
        {
            ScreensManager.Options.gameObject.SetActive(true);

            yield return base.Init();
        }

        protected override IEnumerator End()
        {
            ScreensManager.Options.gameObject.SetActive(false);

            return base.End();
        }

        protected override void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                Parent.Activate<MenuState>();

            base.Update();
        }
    }
}
