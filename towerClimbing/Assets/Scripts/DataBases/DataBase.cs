using Assets.Scripts.DataBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using LitJson;

namespace Assets.Scripts.DataBases
{
    class DataBase: MonoBehaviour
    {
        private static DataBase instance;

        [SerializeField]
        TextAsset levelList;

        private void Awake()
        {
            if (!instance)
                instance = this;
        }


        public static List<Level> Levels
        {
            get
            {
                return JsonMapper.ToObject<List<Level>>(instance.levelList.text);
            }
        }

    }
}
