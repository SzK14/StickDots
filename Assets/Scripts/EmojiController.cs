using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmojiController : MonoBehaviour
{
    public static EmojiController instance;

    [SerializeField] private GameObject emojiPrefab;
    [SerializeField] private string emojiAnimation;
    [SerializeField] private float emojiLifeTime = 5f;

    private Queue<EmojiQueueItem> emojiQueue = new Queue<EmojiQueueItem>();
    private bool canSpawnEmoji = true;

    private void Awake()
    {
        instance = this;
    }

    public void EnqueueEmoji(int emojiIndex, string userId)
    {
        EmojiQueueItem item = new EmojiQueueItem(emojiIndex, userId);
        emojiQueue.Enqueue(item);
    }

    private void Start()
    {
        StartCoroutine(EmojiPlayback());
    }

    private IEnumerator EmojiPlayback()
    {
        while (true)
        {
            if (emojiQueue.Count > 0 && canSpawnEmoji)
            {
                EmojiQueueItem item = emojiQueue.Dequeue();
                StartCoroutine(SpawnEmoji(item));
            }
            yield return new WaitForSeconds(emojiLifeTime);
        }
    }

    private IEnumerator SpawnEmoji(EmojiQueueItem item)
    {
        canSpawnEmoji = false;

        GameObject avatar = GetAvatarByUserId(item.UserId);
        if (avatar != null)
        {
            StartCoroutine(ScaleAvatar(avatar));
            GameObject emojiInstance = Instantiate(emojiPrefab, avatar.transform.position, Quaternion.identity);
            emojiInstance.GetComponentInChildren<Animator>().Play(emojiAnimation);
            Destroy(emojiInstance, emojiLifeTime);
        }

        yield return new WaitForSeconds(emojiLifeTime);
        canSpawnEmoji = true;
    }

    private IEnumerator ScaleAvatar(GameObject avatar)
    {
        Vector3 originalScale = avatar.transform.localScale;
        Vector3 targetScale = originalScale * 1.2f;
        float duration = 0.5f;

        float time = 0;
        while (time < duration)
        {
            avatar.transform.localScale = Vector3.Lerp(originalScale, targetScale, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        avatar.transform.localScale = originalScale;
    }

    private GameObject GetAvatarByUserId(string userId)
    {
        GameObject avatar = GameObject.Find(userId);
        return avatar;
    }
}

public class EmojiQueueItem
{
    public int EmojiIndex;
    public string UserId;

    public EmojiQueueItem(int emojiIndex, string userId)
    {
        EmojiIndex = emojiIndex;
        UserId = userId;
    }
}
