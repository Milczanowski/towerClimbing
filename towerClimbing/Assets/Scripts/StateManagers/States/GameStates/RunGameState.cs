using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.StateManagers.States.GameStates
{
    class RunGameState: State
    {
        protected override IEnumerator Init()
        {
            return base.Init();
        }

        protected override IEnumerator End()
        {
            return base.End();
        }

        protected override void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                Parent.Activate<ExitGameState>();

            base.Update();
        }
    }
}
