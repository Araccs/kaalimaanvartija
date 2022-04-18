using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class CheatCode : MonoBehaviour
    {

        // Start is called before the first frame update
        public void OpenLevels()
        {
            LevelStateChecker.level2open = 1;
            LevelStateChecker.level3open = 1;
            LevelStateChecker.level4open = 1;
            LevelStateChecker.level5open = 1;

        }

    }
}
