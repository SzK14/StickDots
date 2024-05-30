using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

enum PlayerColour
{
    player_blue,
    player_red
}

public class BoxComplete : MonoBehaviour
{
    private List<GameObject> boxBackgrounds = new List<GameObject>();

    private Material activeColor;
    [SerializeField] private Shader completionShader;
    [SerializeField] private AudioClip audioClip;

    private int winPlayer;

    //[SerializeField] Player winPlayer;
    //[SerializeField] int col;
    //[SerializeField] int x, y;

    private bool blingMode;

    private Queue<Vector3> boxesToAnimate = new Queue<Vector3>();
    private bool isAnimating = false;

    public List<GameObject> BoxBackgrounds
    {
        get { return boxBackgrounds; }
        set { boxBackgrounds = value; }
    }

    private void Start()
    {
        // Width in GameManager stores num of dots
        // For box need to -1
        //col = GamePlayManager.Instance.W - 1;

        blingMode = false;
        ResetBling();
    }

    int getBoxHash(int x, int y)
    {
        // hash code for coord
        return x + (y * (GamePlayManager.Instance.W - 1));
    }
    public void PlayCaptureBoxAnim(Vector3 boxCoordAndCapturedBy)
    {
        int x = (int)boxCoordAndCapturedBy.x;
        int y = (int)boxCoordAndCapturedBy.y;
        int winPlayer = (int)boxCoordAndCapturedBy.z;

        // Get the specific game object renderer by hash code
        Renderer ren = boxBackgrounds[getBoxHash(x, y)].gameObject.GetComponent<Renderer>();

        // Activate the game object
        ren.gameObject.SetActive(true);

        // Create a new material and set its color
        Material activeColor = new Material(completionShader);
        activeColor.SetColor("_baclgroundColor", GamePlayManager.Instance.players[winPlayer].myColor);
        ren.material = activeColor;

        // Add the box coordinate to the queue
        boxesToAnimate.Enqueue(boxCoordAndCapturedBy);

        // If this is the first box to animate, start the animation coroutine
        if (!isAnimating)
        {
            StartCoroutine(AnimateBoxes());
        }
    }

    private IEnumerator AnimateBoxes()
    {
        isAnimating = true;

        while (boxesToAnimate.Count > 0)
        {
            Vector3 nextBoxCoord = boxesToAnimate.Dequeue();
            int x = (int)nextBoxCoord.x;
            int y = (int)nextBoxCoord.y;

            Renderer ren = boxBackgrounds[getBoxHash(x, y)].gameObject.GetComponent<Renderer>();

            float animationDuration = 1.0f;
            float elapsedTime = 0f;

            while (elapsedTime < animationDuration)
            {
                elapsedTime += Time.deltaTime;
                float offset = Mathf.Lerp(0, 1, elapsedTime / animationDuration);
                ren.material.SetFloat("_HighLightOffset", offset);
                yield return null;
            }

            ren.material.SetFloat("_HighLightOffset", 1.0f);

            // Wait for a brief delay before the next animation
            yield return new WaitForSeconds(0.5f);
        }

        isAnimating = false;
    }

    private void ResetBling()
    {
        blingMode = false;
    }

    private void Update()
    {
        if (blingMode)
        {
            float offset = activeColor.GetFloat("_HighLightOffset");
            activeColor.SetFloat("_HighLightOffset", offset + Time.deltaTime / 1.0f);
            if (offset >= 1.0f) ResetBling();
        }
    }
}