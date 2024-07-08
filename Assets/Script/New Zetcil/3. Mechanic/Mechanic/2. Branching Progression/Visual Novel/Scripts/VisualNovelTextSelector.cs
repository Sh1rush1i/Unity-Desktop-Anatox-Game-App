using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zetcil
{

    public class VisualNovelTextSelector : MonoBehaviour
    {

        [System.Serializable]
        public enum CLanguageType
        {
            Indonesian, English, Korean, Chinese, Arabian, Japanese
        }

        [Header("Main Settings")]
        public Text TargetText;

        [Header("Language Settings")]
        public CLanguageType LanguageType;
        [TextArea(5, 10)]
        public string IndonesianText;
        [TextArea(5, 10)]
        public string EnglishText;
        [TextArea(5, 10)]
        public string ArabicText;
        [TextArea(5, 10)]
        public string ChineseText;
        [TextArea(5, 10)]
        public string KoreanText;
        [TextArea(5, 10)]
        public string JapaneseText;

        public void LoadCurrentLanguage()
        {
            if (PlayerPrefs.GetString("LANGUAGE") == "INDONESIAN")
            {
                LanguageType = CLanguageType.Indonesian;
                TargetText.text = IndonesianText;
            }
            if (PlayerPrefs.GetString("LANGUAGE") == "ENGLISH")
            {
                LanguageType = CLanguageType.English;
                TargetText.text = EnglishText;
            }
            if (PlayerPrefs.GetString("LANGUAGE") == "CHINESE")
            {
                LanguageType = CLanguageType.Chinese;
                TargetText.text = ChineseText;
            }
            if (PlayerPrefs.GetString("LANGUAGE") == "KOREAN")
            {
                LanguageType = CLanguageType.Korean;
                TargetText.text = KoreanText;
            }
            if (PlayerPrefs.GetString("LANGUAGE") == "JAPANESE")
            {
                LanguageType = CLanguageType.Japanese;
                TargetText.text = JapaneseText;
            }
            if (PlayerPrefs.GetString("LANGUAGE") == "ARABIAN")
            {
                LanguageType = CLanguageType.Arabian;
                TargetText.text = ArabicText;
            }
            Debug.Log(PlayerPrefs.GetString("LANGUAGE"));
        }

        bool isStart = false;

         // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void LateUpdate()
        {
            if (!isStart)
            {
                LoadCurrentLanguage();
                isStart = true;
            }
        }
    }
}
