using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace kaalimaanvartija
{
    public class LevelButtonChanger : MonoBehaviour
    {
        public Sprite newImg;
        private Image locked;
        [SerializeField] private string levelName;
        void Awake()
        {
            locked = this.GetComponent<Image>();
            levelName = (levelName + "open");
            LevelStateChecker.level2open = true;
        }

        // Update is called once per frame
        void Update()
        {
        if(LevelStateChecker.level2open == true)
            {
                locked.sprite = newImg;
            }
        }
    }
}
