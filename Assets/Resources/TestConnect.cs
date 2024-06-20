using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class TestConnect : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject gameModesUI; 
    [SerializeField] private TextMeshProUGUI roomName; 
    [SerializeField] private Button startGameButton; 
    private TextMeshProUGUI buttonText;

    private void Awake() {
       if (gameModesUI != null) {
        gameModesUI.SetActive(false);
       }
       if (startGameButton != null) {
        buttonText = startGameButton.gameObject.GetComponentInChildren<TextMeshProUGUI>();
       }
    }
    void Start()

    {
        print ("Connecting to server");
        PhotonNetwork.ConnectUsingSettings(); //Connects to Photon server
        //PhotonNetwork.GameVersion = "0.0.1";
        
    }

    public void LeaveRoom() {
        PhotonNetwork.LeaveRoom();
    }
    public override void OnConnectedToMaster() //Callback function for when the first connection is established
    {
        PhotonNetwork.JoinLobby(); //Joins the Photon Lobby
        gameModesUI.SetActive(true);
        Debug.Log("Connected to Master");
    }

    public override void OnJoinedLobby() //Callback function for when the first connection is established
    {
        Debug.Log("Made it to Lobby");
    }

    //public override void OnCreatedRoom()
    //{
    //    roomName.text = PhotonNetwork.CurrentRoom.Name;
    //    base.OnCreatedRoom();
    //}

    public override void OnJoinedRoom()
    {
        if (!PhotonNetwork.LocalPlayer.IsMasterClient) {
            startGameButton.interactable = false;
            
            buttonText.text = "Waiting for Host";
            buttonText.enableAutoSizing = true;
        }
    }

}