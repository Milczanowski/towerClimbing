using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GUI.Panels
{
    class Level: MonoBehaviour
    {
        [SerializeField]
        private Text levelName;

        [SerializeField]
        private Button runButton;

        private DataBases.Models.Level LevelData { get; set; }

        Action<DataBases.Models.Level> OnClick { get; set; }

        public Level Set(DataBases.Models.Level levelData, Action<DataBases.Models.Level> onClick)
        {
            LevelData = levelData;
            OnClick = onClick;
            runButton.onClick.AddListener(OnButtonClick);

            levelName.text = LevelData.Name;
            runButton.interactable = LevelData.Unlocked;

            return this;
        }

        private void OnButtonClick()
        {
            OnClick(LevelData);
        }
    }
}
