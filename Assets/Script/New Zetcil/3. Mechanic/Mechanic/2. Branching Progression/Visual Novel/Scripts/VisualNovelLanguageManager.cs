using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VisualNovelLanguageManager : MonoBehaviour
{
    [System.Serializable]
    public enum CLanguageType
    {
        Indonesian, English, Korean, Chinese, Arabian, Japanese
    }

    [Header("Main Settings")]
    public CLanguageType LanguageType;
    public bool SaveOnAwake;

    [Header("Event Settings")]
    public UnityEvent StartEvents;
    public UnityEvent UpdateEvents;

    public void LoadCurrentLanguage()
    {
        if (PlayerPrefs.GetString("LANGUAGE") == "INDONESIAN")
        {
            LanguageType = CLanguageType.Indonesian;
        }
        if (PlayerPrefs.GetString("LANGUAGE") == "ENGLISH")
        {
            LanguageType = CLanguageType.English;
        }
        if (PlayerPrefs.GetString("LANGUAGE") == "CHINESE")
        {
            LanguageType = CLanguageType.Chinese;
        }
        if (PlayerPrefs.GetString("LANGUAGE") == "KOREAN")
        {
            LanguageType = CLanguageType.Korean;
        }
        if (PlayerPrefs.GetString("LANGUAGE") == "ARABIAN")
        {
            LanguageType = CLanguageType.Arabian;
        }
        if (PlayerPrefs.GetString("LANGUAGE") == "JAPANESE")
        {
            LanguageType = CLanguageType.Japanese;
        }
        Debug.Log(PlayerPrefs.GetString("LANGUAGE"));
    }

    public void SaveCurrentLanguage()
    {
        if (LanguageType == CLanguageType.Indonesian)
        {
            PlayerPrefs.SetString("LANGUAGE", "INDONESIAN");
        }
        if (LanguageType == CLanguageType.English)
        {
            PlayerPrefs.SetString("LANGUAGE", "ENGLISH");
        }
        if (LanguageType == CLanguageType.Chinese)
        {
            PlayerPrefs.SetString("LANGUAGE", "CHINESE");
        }
        if (LanguageType == CLanguageType.Korean)
        {
            PlayerPrefs.SetString("LANGUAGE", "KOREAN");
        }
        if (LanguageType == CLanguageType.Arabian)
        {
            PlayerPrefs.SetString("LANGUAGE", "ARABIAN");
        }
        if (LanguageType == CLanguageType.Japanese)
        {
            PlayerPrefs.SetString("LANGUAGE", "JAPANESE");
        }
    }

    public void SelectIndonesian()
    {
        LanguageType = CLanguageType.Indonesian;
    }

    public void SelectEnglish()
    {
        LanguageType = CLanguageType.English;
    }

    public void SelectChinese()
    {
        LanguageType = CLanguageType.Chinese;
    }

    public void SelectKorean()
    {
        LanguageType = CLanguageType.Korean;
    }

    public void SelectArabian()
    {
        LanguageType = CLanguageType.Arabian;
    }

    public void SelectJapanese()
    {
        LanguageType = CLanguageType.Japanese;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (SaveOnAwake)
        {
            SaveCurrentLanguage();
        }

        StartEvents?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateEvents?.Invoke();
    }
}
