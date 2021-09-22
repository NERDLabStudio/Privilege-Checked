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
    }

    public void HasDescription(string text)
    {
        Debug.Log("Running as description with " + text);
        Description.transform.parent.gameObject.SetActive(true);
        Description.text = text;
        Debug.Log("GAME OBJECT:" + Description.transform.parent.gameObject.name);
    }

    public void NoDescription()
    {
        Debug.Log("No Description!");
        Description.text = "";
        Description.transform.parent.gameObject.SetActive(false);
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
