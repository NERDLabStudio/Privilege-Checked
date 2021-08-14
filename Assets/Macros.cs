using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Macros : MonoBehaviour
{
    public Text Description;
    public Image Character;
    void Start()
    {
        Description.gameObject.SetActive(false);
    }

    public void HasDescription(string text)
    {
        Description.gameObject.SetActive(true);
        Description.text = text;
    }

    public void NoDescription()
    {
        Description.text = "";
        Description.gameObject.SetActive(false);
    }

    public void ChangeCharacterImage(string image)
    {
        //Load a Sprite (Assets/Resources/Mixed/Alya_Listening.png)

        //        var sprite = Resources.Load<Sprite>("Mixed/Alya_Listening");

        var sprite = Resources.Load<Sprite>(image);
        Character.sprite = sprite;
    }

    public void Links()
    {
        Debug.Log("Links called");
    }

}
