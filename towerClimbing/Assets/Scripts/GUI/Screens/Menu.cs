using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GUI.Screens
{
    class Menu: MonoBehaviour
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

             
    }
}
