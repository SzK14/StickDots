using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FMOD;
using FMODUnity;
using GameEvents;

public class SceneController : MonoBehaviour
{
    [SerializeField] IntEventAsset _sceneChangeEvent;
    public void SwitchScene(int sceneID)
    {
        _sceneChangeEvent.Invoke(sceneID);
        ChannelGroup mcg;
        RuntimeManager.CoreSystem.getMasterChannelGroup(out mcg);
        mcg.stop();
        SceneManager.LoadScene(sceneID);
    }
}
