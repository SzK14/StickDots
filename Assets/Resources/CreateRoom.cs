using Photon.Pun;
using Photon.Realtime;
using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinAndCreate : MonoBehaviourPunCallbacks
{
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private static System.Random random = new System.Random();

    // this holds a reference to the create input field
    public TextMeshProUGUI createInputField;
    // this holds a reference to the join input field
    public TextMeshProUGUI joinInputField;
    // create a room (automatically joins the room created)
    [SerializeField] string sceneToLoad;

    private void Awake()
    {
        //string code = GetRandomString(4);
        //createInputField.text = code;
        //joinInputField.text = code;
    }

    public string GetRandomString(int length)
    {
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public void CreateRoom()
    {
        RoomOptions roomOpts = new RoomOptions {
            IsVisible = true, 
            IsOpen = true,
            EmptyRoomTtl = 0, 
        };
        PhotonNetwork.CreateRoom(createInputField.text, roomOpts);
        
    }
    
    // join a room
    public void JoinRoom()
    {
        String trimmedString = joinInputField.text.Trim((char)8203);
        PhotonNetwork.JoinRoom(trimmedString);
        //Debug.Log(joinInputField.text);
        //Debug.Log(PhotonNetwork.CurrentRoom.Name);
        //Debug.Log(PhotonNetwork.InRoom);
    }

    // on join room, load the gameplay scene
    public override void OnJoinedRoom()
    {
        Debug.Log("Joined");
        GamePlayManager.Instance.JoinRoomRPC();
        //PhotonNetwork.LoadLevel(sceneToLoad);
    }

    
}