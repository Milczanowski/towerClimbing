using Assets.Scripts.GUI;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.StateManagers.States
{
    class InitState: State
    {
        protected override IEnumerator Init()
        {
            ScreensManager.InitPanel.gameObject.SetActive(true);
            yield return new WaitForSeconds(2);
            yield return base.Init();

            Parent.Activate<MenuState>();
        }


        protected override IEnumerator End()
        {
            ScreensManager.InitPanel.gameObject.SetActive(false);
            return base.End();
        }
    }
}
