using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GUI.Screens
{
    class Menu: Screen
    {
        [SerializeField]
        private Button startButton;

        [SerializeField]
        private Button optionsButton;

        [SerializeField]
        private Button creditsButton;

        [SerializeField]
        private Button exitButton;

        public Button StartButton
        {
            get
            {
                return startButton;
            }
        }

        public Button OptionsButton
        {
            get
            {
                return optionsButton;
            }
        }

        public Button CreditsButton
        {
            get
            {
                return creditsButton;
            }
        }

        public Button ExitButtons
        {
            get
            {
                return exitButton;
            }
        }

        public override void RemoveAllListeners()
        {
            StartButton.onClick.RemoveAllListeners();
            OptionsButton.onClick.RemoveAllListeners();
            CreditsButton.onClick.RemoveAllListeners();
            ExitButtons.onClick.RemoveAllListeners();

            base.RemoveAllListeners();
        }


    }
}
