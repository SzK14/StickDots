using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
    private bool isTurnActive = false;
    public Color myColor = new Color(255, 0, 0);
    public int playerIndex { get; set; }

    public string playerName = "Player";
    public int score = 0;
    public int rank = 0;
    public bool isLocal = false;

    public void BeginTurn()
    {
        isTurnActive = true;
        UIManager.Instance.IndicatorColorSwitch(myColor);
    }

    public void EndTurn()
    {
        isTurnActive = false;
    }
}
