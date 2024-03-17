using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.Events;

enum PlayerColour
{
    player_blue,
    player_red
}

public class BoxComplete : MonoBehaviour
{
    public List<GameObject> boxes = new List<GameObject>();

    [SerializeField] Material blueColor;
    [SerializeField] Material redColor;
    [SerializeField] Material activeColor;


    private int col;
    private PlayerColour winPlayer;
    //[SerializeField] Player winPlayer;
    //[SerializeField] int col;
    //[SerializeField] int x, y;
    [SerializeField] bool blingMode;

    private void Start()
    {
        // Width in GameManager stores num of dots
        // For box need to -1
        col = GameManager.Instance.w - 1;
        blingMode = true;
    }

    int getBoxHash(int x, int y)
    {
        // hash code for coord
        return x + (y * (col));
    }

    //private void Start()
    //{
    //    //get the specific gameobject render by hash code
    //    Renderer ren = boxes[getBoxHash(x, y)].gameObject.GetComponent<Renderer>();
    //    //set
    //    if (winPlayer == Player.player_blue)
    //    {
    //        activeColor = blueColor;
    //    }
    //    else if (winPlayer == Player.player_red)
    //    {
    //        activeColor = redColor;
    //    }
    //    //reset the bling offset
    //    ResetBling();

    //    //turn on bling
    //    blingMode = true;

    //    //set the material for the game object
    //    ren.material = activeColor;
    //}

    public void PlayCaptureBoxAnim(Vector3 boxCoordAndCapturedBy) 
    {
        int x = (int)boxCoordAndCapturedBy.x;
        int y = (int)boxCoordAndCapturedBy .y;
        winPlayer = (PlayerColour)boxCoordAndCapturedBy.z;
        //get the specific gameobject render by hash code
        Renderer ren = boxes[getBoxHash(x, y)].gameObject.GetComponent<Renderer>();
        //set
        if (winPlayer == PlayerColour.player_blue)
        {
            activeColor = blueColor;
        }
        else if (winPlayer == PlayerColour.player_red)
        {
            activeColor = redColor;
        }

        ren.material = activeColor;
    }

    private void ResetBling()
    {
        blingMode = false;
        //reset bling offset to 0
        activeColor.SetFloat("_HighLightOffset",0.0f);
    }

    private void Update()
    {
        if (blingMode)
        {
            //if it is blinging
            //get the offset now and increase it by a rate
            float offset = activeColor.GetFloat("_HighLightOffset");
            activeColor.SetFloat("_HighLightOffset", offset + Time.deltaTime/3.0f);
        }
    }

}
