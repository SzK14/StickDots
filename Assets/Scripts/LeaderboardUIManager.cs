using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeaderboardUIManager : MonoBehaviour
{
    //[SerializeField] private LeaderboardScoreView leaderboardScoreView;
    //[SerializeField] private Transform container;

    //private void OnEnable()
    //{
    //    //LeaderboardManager.Instance.LoadScoresAsync();
    //}
    private void Start()
    {
        LeaderboardManager.Instance.LoadScoresAsync();
    }

}
