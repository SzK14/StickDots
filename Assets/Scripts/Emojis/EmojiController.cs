using System.Collections;
using TMPro;
using UnityEngine;

public class EmojiController : MonoBehaviour
{
    [SerializeField] private GameObject emojiPrefab;
    [SerializeField] private string emojiAnimation;
    [SerializeField] private Transform spawnTransform; // This should be the players position 
    [SerializeField] private bool canSpawnEmoji = true;
    [SerializeField] private float emojiLifeTime = 5f;

    [Header("Player data")]
    [SerializeField] private int _emojiIndex;
    [SerializeField] private int _userIndex;
    [SerializeField] private string _userName;

    private void Awake()
    {
        spawnTransform = GameObject.FindGameObjectWithTag("EmojiSpawn").transform;
        canSpawnEmoji = true;
    }

    public void BTPlayEmoji()
    {
        SpawnEmoji(_emojiIndex, _userIndex, _userName);
    }

    //[PunRPC]
    public void SpawnEmoji(int emojiIndex, int userIndex, string userName)               
    {
        if(canSpawnEmoji)
        {
            canSpawnEmoji = false;
            StartCoroutine(EmojiCooldown());
            // Instatiates an emoji at the player's emoji transform
            GameObject emojiInstance = Instantiate(emojiPrefab, spawnTransform);
            emojiInstance.GetComponentInChildren<Animator>().Play(emojiAnimation);

            // Update emoji username
            GetComponentInChildren<TextMeshProUGUI>().text = userName;

            Destroy(emojiInstance, emojiLifeTime);
        }     
    }

    IEnumerator EmojiCooldown()
    {
        yield return new WaitForSeconds(emojiLifeTime);
        canSpawnEmoji = true;
    }
}
