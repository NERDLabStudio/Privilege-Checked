using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;


public class PassageMacros: Cradle.RuntimeMacros
{
    [RuntimeMacro]
    public void description(string passage)
    {
        this.Story.GetComponent<Macros>().SendMessage("HasDescription", passage);
    }

    [RuntimeMacro]
    public void noDescription()
    {
        this.Story.GetComponent<Macros>().SendMessage("NoDescription");
    }

    [RuntimeMacro]
    public void links(string link1, string link2 = "", string link3 = "")
    {
        int linkCount = 1;
        if(link2.Length > 0)
        {
            linkCount++;
        }
        if(link3.Length > 0)
        {
            linkCount++;
        }
        Debug.Log(linkCount + " links added to vault");
    }

    [RuntimeMacro]
    public void image(string file)
    {
        this.Story.GetComponent<Macros>().SendMessage("ChangeCharacterImage", file);
    }
}
