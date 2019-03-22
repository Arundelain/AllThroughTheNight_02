using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;


public class TapToChangeColor : MonoBehaviour {
    GestureRecognizer recognizer;

	
	void Awake () {
        recognizer = new GestureRecognizer();
        recognizer.SetRecognizableGestures(GestureSettings.Tap);
        recognizer.StartCapturingGestures();
	}
	
	
	void OnEnable () {
        recognizer.TappedEvent += Recognizer_TappedEvent;
	}
    void OnDisable()
    {
        recognizer.TappedEvent -= Recognizer_TappedEvent;
    }

    private void Recognizer_TappedEvent(InteractionSourceKind source, int tapCount, Ray headRay)
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
