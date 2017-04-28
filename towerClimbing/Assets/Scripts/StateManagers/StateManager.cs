﻿using System.Collections;
using UnityEngine;


namespace Assets.Scripts.StateManagers
{
    class StateManager : MonoBehaviour
    {
        private static Root AppState;

        public static StateManager Current { get; private set; }

        private void Awake()
        {
            if (!Current)
            {
                Current = this;
                DontDestroyOnLoad(Current);
            }
        }

        private IEnumerator Start()
        {
            AppState = new Root();
            yield return AppState.Enable();
        }

        private void Update()
        {
            if (AppState != null)
                AppState._Update();
        }

        public static void StartCorutine(IEnumerator e)
        {
            Current.StartCoroutine(e);
        }
    }
}
