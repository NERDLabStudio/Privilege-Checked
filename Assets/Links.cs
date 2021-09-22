using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Links : MonoBehaviour
{
    private int currentLinkIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Deactivate()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    public void Set(int index = 0)
    {
        transform.GetChild(index).gameObject.SetActive(true);
        currentLinkIndex = index;       

    }

    public void Next()
    {
        currentLinkIndex++;
        if(currentLinkIndex >= transform.childCount)
        {
            currentLinkIndex = 0;
        }
        Deactivate();
        Set(currentLinkIndex);
    }


    public void Previous()
    {
        currentLinkIndex--;
        if (currentLinkIndex < 0)
        {
            currentLinkIndex = transform.childCount - 1;
        }
        Set(currentLinkIndex);

    }
}
