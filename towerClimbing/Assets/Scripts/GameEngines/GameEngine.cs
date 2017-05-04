using Assets.Scripts.DataBases.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.GameEngines
{
    public class GameEngine
    {
        public static Level Level
        {
            get; private set;
        }


        public static void SetLevel(Level level)
        {
            Level = level;
        }

        public static IEnumerator LoadLevel(Action onFinish, Action<float> onProgress)
        {
            int i =0;
            float maxIter = 50;

            while(i <maxIter)
            {
                yield return new WaitForSeconds(0.01f);
                if(onProgress!=null)
                    onProgress(i /maxIter);
                ++i;
            }


            if (onFinish != null)
                onFinish();
        }

    }
}
