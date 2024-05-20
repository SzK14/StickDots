using UnityEngine;
using VoxelBusters.EssentialKit;

public class SocialShare : MonoBehaviour
{
    [SerializeField] public string shareText = "";
    private ShareSheet _shareSheet;

    //ont start create instance
    private void Start()
    {
        _shareSheet = ShareSheet.CreateInstance();
    }

    //call on game end to automatically take screen shot
    public void TakeScreeShot()
    {
        Debug.Log("add text and screenshot");
        if (_shareSheet != null) 
        {
            _shareSheet.AddText(shareText);
            _shareSheet.AddScreenshot();
        }
    }

    //call when share button is clicked
    public void Share()
    {
        Debug.Log("share");
        if (_shareSheet != null) { 
            _shareSheet.Show();
        }
    }

    //Test Button function
    public void Test()
    {
        TakeScreeShot();
        Share();
    }
    
}
