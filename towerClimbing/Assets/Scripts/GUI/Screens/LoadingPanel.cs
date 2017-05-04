using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GUI.Screens
{
    class LoadingPanel: Screen
    {
        [SerializeField]
        private Image progressBar;

        [SerializeField]
        private int maxProgressBarWidth = 500;

        public void OnProgress(float progress)
        {
            Debug.Log(progress);
            progressBar.rectTransform.sizeDelta = new Vector2(maxProgressBarWidth * progress, progressBar.rectTransform.sizeDelta.y);            
        }
    }
}
