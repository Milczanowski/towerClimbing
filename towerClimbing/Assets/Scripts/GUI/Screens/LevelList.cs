using Assets.Scripts.DataBases;
using Assets.Scripts.GUI.Panels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.GUI.Screens
{
    class LevelList: Screen
    {
        [SerializeField]
        private Transform container;

        [SerializeField]
        private Level levelPrefabs;

        private List<Level> LevelsList { get; set; }
        public void LoadLevels(Action<DataBases.Models.Level> onClick)
        {
            if (LevelsList == null)
                LevelsList = new List<Level>();
            else
                UnLoadLevels();

            foreach (var level in DataBase.Levels)
                LevelsList.Add(Instantiate(levelPrefabs, container).Set(level, onClick));
        }
        public void UnLoadLevels()
        {
            foreach (Level child in LevelsList)
                Destroy(child.gameObject);

            LevelsList.Clear();
        }
             
    }
}
