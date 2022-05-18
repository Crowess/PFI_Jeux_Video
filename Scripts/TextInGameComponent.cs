using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInGameComponent : MonoBehaviour
{
    Text title;
    void Awake()
    {
        title = GetComponent<Text>();
        string playerName = !string.IsNullOrEmpty(PlayerPrefs.GetString("PlayerName")) ? PlayerPrefs.GetString("PlayerName") : "Default";
        float lvlDifficulty = PlayerPrefs.GetFloat("Difficulty") != 0 ? PlayerPrefs.GetFloat("Difficulty") : 1;
        string devMode = PlayerPrefs.GetInt("devMode") == 0 ? "" : "This game launched in dev mode";

        title.text = string.Format($"Hello {playerName} you are on Difficulty lvl : {lvlDifficulty} " +
                                   $"to continue please buy the full version of the game. "+devMode);
    }
}
