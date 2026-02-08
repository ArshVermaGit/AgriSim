using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Reflection;

[InitializeOnLoad]
public class ReadmeTopBar : Editor {
	
	static string kShowedReadmeSessionStateName = "ReadmeTopBar.showedReadme";

	static ReadmeTopBar()
	{
		EditorApplication.delayCall += SelectReadmeAutomatically;
	}
	
	static void SelectReadmeAutomatically()
	{
		if (!SessionState.GetBool(kShowedReadmeSessionStateName, false ))
		{
			var readme = SelectReadme();
			SessionState.SetBool(kShowedReadmeSessionStateName, true);
		
		} 
	}

	
	[MenuItem("Read Me/Select Welcome Window")]
	static ResourcesDataScriptable SelectReadme() 
	{
		var ids = AssetDatabase.FindAssets("t:ResourcesDataScriptable");
		if (ids.Length == 1)
		{
			var readmeObject = AssetDatabase.LoadMainAssetAtPath(AssetDatabase.GUIDToAssetPath(ids[0]));
			
			Selection.objects = new UnityEngine.Object[]{readmeObject};
			
			return (ResourcesDataScriptable)readmeObject;
		}
		else
		{
			Debug.Log("Couldn't find a readme");
			return null;
		}
	}
	[MenuItem("Read Me/Get the e-book")]
	static void OpenWebLink()
	{
		Application.OpenURL("https://resources.unity.com/games/2d-game-art-animation-lighting-for-artists-ebook?isGated=false"); //replace with your own links
	}
	
	

}

