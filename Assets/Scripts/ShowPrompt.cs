using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//get access to unitys UI system
using UnityEngine.UI;

//Before Using Check 2 things are done: XR Origin has 'player' tag.  have canvas with text and Trigger enabled hitBox

public class ShowPrompt : MonoBehaviour
{
	//Canvas shows user prompt
    public Canvas triggerCanvas;
    
	void OnTriggerEnter(Collider colEnter)
	{
		if (colEnter.tag == "Player")
		{
			Debug.Log("Player is near TP prompt");
			//Show the E prompt Canvas
			triggerCanvas.enabled = true;
		}
	}

	void OnTriggerExit(Collider colExit)
	{
		if(colExit.tag == "Player")
		{
			Debug.Log("Player has Left TP prompt");
			//Hide the prompt
			triggerCanvas.enabled = false;
		}
	}


}
