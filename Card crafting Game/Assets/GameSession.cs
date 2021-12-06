using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI levelNumberText;
    [SerializeField] bool clearPlayerPrefs = false;

    LevelLoader levelLoader;
    int currLevel;
    //[SerializeField] GameObject continueButton;
    // Start is called before the first frame update
    void Start()
    {
        if(clearPlayerPrefs)
            PlayerPrefs.DeleteAll();
        currLevel = PlayerPrefs.GetInt("Level", 1);
        levelNumberText.text = currLevel.ToString();
        levelLoader = FindObjectOfType<LevelLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Continue()
    {
        currLevel++;
        PlayerPrefs.SetInt("Level", currLevel);
        levelLoader.LoadNextScene();
    }

}
