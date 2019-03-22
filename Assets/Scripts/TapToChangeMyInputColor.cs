using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule; //I added this after adding the input manager to my scene

public class TapToChangeMyInputColor : MonoBehaviour,IInputClickHandler,IFocusable {

    public void OnInputClicked(InputClickedEventData eventData)
    {
        //this is just going to change the color of some object so get the component it is on and its renderer
        GetComponent<Renderer>().material.color = Random.ColorHSV();

    }//end input clicked
    public void OnFocusEnter()
    {
        //while you are looking at the object, multiply it by a scale of 20%
        transform.localScale *= 1.2f; //have to have the f here


    }//end on focus
    public void OnFocusExit(){
        transform.localScale /= 1.2f; //have to have the f here

    }//end onfocus exit

}//end class
