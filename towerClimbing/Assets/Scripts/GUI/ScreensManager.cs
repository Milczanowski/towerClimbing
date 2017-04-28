using Assets.Scripts.GUI.Screens;
using UnityEngine;

namespace Assets.Scripts.GUI
{
    class ScreensManager:MonoBehaviour
    {
        private static ScreensManager instance;

        [SerializeField]
        private InitPanel initPanel;

        [SerializeField]
        private LoadingPanel loadingPanel;

        [SerializeField]
        private Menu menu;

        [SerializeField]
        private GameGUI gameGUI;

        [SerializeField]
        private Options options;

        [SerializeField]
        private Creadits credits;

        [SerializeField]
        private LevelList levelList;

        private void Awake()
        {
            if (!instance)
                instance = this;
        }

        public static InitPanel InitPanel
        {
            get
            {
                return instance.initPanel;
            }
        }

        public static LoadingPanel LoadingPanel
        {
            get
            {
                return instance.loadingPanel;
            }
        }

        public static Menu Menu
        {
            get
            {
                return instance.menu;
            }
        }

        public static GameGUI GameGUI
        {
            get
            {
                return instance.gameGUI;
            }
        }

        public static Options Options
        {
            get
            {
                return instance.options;
            }
        }

        public static Creadits Credits
        {
            get
            {
                return instance.credits;
            }
        }

        public static LevelList LevelList
        {
            get
            {
                return instance.levelList;
            }
        }
    }
}
