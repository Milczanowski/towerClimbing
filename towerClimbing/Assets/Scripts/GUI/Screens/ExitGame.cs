using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GUI.Screens
{
    class ExitGame: Screen
    {
        [SerializeField]
        private Button yesButton;

        [SerializeField]
        private Button noButton;

        public Button YesButton
        {
            get
            {
                return yesButton;
            }
        }

        public Button NoButton
        {
            get
            {
                return noButton;
            }
        }

        public override void RemoveAllListeners()
        {
            ScreensManager.ExitGame.NoButton.onClick.RemoveAllListeners();
            ScreensManager.ExitGame.YesButton.onClick.RemoveAllListeners();
            base.RemoveAllListeners();
        }

    }
}
