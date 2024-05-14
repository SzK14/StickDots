using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    //[SerializeField] private AudioClip backgroundMusicClip;
    [SerializeField] private EventReference _menuMusic;
    [SerializeField] private EventReference _ingameMusic;

    private AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // audioSource = gameObject.AddComponent<AudioSource>();
        // audioSource.loop = true;

        // if (backgroundMusicClip != null)
        // {
            PlayBackgroundMusic();
        // }
    }

    public void PlayBackgroundMusic()
    {
        // if (backgroundMusicClip != null && !audioSource.isPlaying)
        // {
        //     audioSource.clip = backgroundMusicClip;
        //     audioSource.Play();
        // }
        RuntimeManager.PlayOneShot(_menuMusic);

    }

    public void PlayInGameMusic()
    {
        RuntimeManager.PlayOneShot(_ingameMusic);
    }
}