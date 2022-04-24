using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class CheatCode : MonoBehaviour
    {
        private int counter;

        void Awake()
        {
            counter = 0;
        }
        // Start is called before the first frame update
        public void OpenLevels()
        {
            counter++;

            if(counter > 10)
            {
                LevelStateChecker.level2open = 1;
                LevelStateChecker.level3open = 1;
                LevelStateChecker.level4open = 1;
                LevelStateChecker.level5open = 1;
            }
            

        }

    }
}
