using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositionContent : MonoBehaviour {

    public Transform Anchor;

	
	
	
	void OnApplicationFocus (bool focus) {
        if (focus)
        {
            StartCoroutine(RepositionContentCoroutine());
        }//end if
	}//end on app focus

    IEnumerator RepositionContentCoroutine()
    {

        yield return new WaitForEndOfFrame();
        //if we are in here then move the content to a specified distance from the user
        transform.position = Anchor.position;
    }//end content coroutine
}
