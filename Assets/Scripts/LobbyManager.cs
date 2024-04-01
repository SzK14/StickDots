using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviour
{
    [SerializeField] private GameObject createRoomPage;
    [SerializeField] private GameObject joinRoomPage;
    [SerializeField] private UnityEvent<int> gameStart;

    private string roomType;
    private void Awake()
    {
        roomType = PlayerPrefs.GetString("RoomType");
        if(roomType == "Create")
        {
            createRoomPage.SetActive(true);
        }
        if (roomType == "Join")
        {
            joinRoomPage.SetActive(true);
        }
    }

    public void GameStart()
    {
        Slider slider = createRoomPage.GetComponentInChildren<Slider>();
        int boardSize = (int) slider.value;
        gameStart.Invoke(boardSize);
    }
}
