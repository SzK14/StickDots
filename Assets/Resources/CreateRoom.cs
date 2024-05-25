using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinAndCreate : MonoBehaviourPunCallbacks
{
    // this holds a reference to the create input field
    public TextMeshProUGUI createInputField;
    // this holds a reference to the join input field
    public TextMeshProUGUI joinInputField;
    // create a room (automatically joins the room created)
    [SerializeField] string sceneToLoad;
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInputField.text);
        
    }
    
    // join a room
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInputField.text);
        Debug.Log(joinInputField.text);
        Debug.Log(PhotonNetwork.CurrentRoom.Name);
        Debug.Log(PhotonNetwork.InRoom);
    }

    // on join room, load the gameplay scene
    public override void OnJoinedRoom()
    {
        Debug.Log("Joined");
        PhotonNetwork.LoadLevel(sceneToLoad);
        SetPlayerNameInRoom();
    }

    public void SetPlayerName(string newName)
    {
        PlayerPrefs.SetString("Name", newName);
    }

    // If player has a saved name, it will become their photon nickname
    public void SetPlayerNameInRoom()
    {
        if (PlayerPrefs.HasKey("Name") && PlayerPrefs.GetString("Name") != null) 
        {
            PhotonNetwork.NickName = PlayerPrefs.GetString("Name");
            Debug.Log(PhotonNetwork.NickName + " has joined the room");
        }
    }
    
}