using UnityEngine;
using System.Collections.Generic;
using System;

[CreateAssetMenu(fileName = "ResourcesDataScriptable", menuName = "Read Me/Create Resource Info")]
public class ResourcesDataScriptable : ScriptableObject
{
    public string windowTitle = "Window title";
    [TextAreaAttribute]
    public string windowSubTitle = "Window subtitle";
    public Texture windowBanner;
    [TextAreaAttribute]
    public string introText = "<b> ABOUT </b ><br> intro text";
    public List<BlockDataScriptable> infoBlock = new();
    
}

    


