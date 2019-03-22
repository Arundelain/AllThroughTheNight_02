using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundScape : MonoBehaviour
{
    // public string toRotateObjectName;
    public GameObject toBeRotated;
    public GameObject toBeMoved;
    //public Renderer rend1;

    public float xAngle, yAngle, zAngle;
    public float maximumAngle;
    public float xDist, yDist, zDist;
    public float maximumDistance;

    private float distCounter;
    private float angleCounter;


    void Start()
    {
        rotateSound(xAngle, yAngle, zAngle);
        translateSound(xDist, yDist, zDist);

    }
    //transform.Translate(timedXDist, timedYDist, timedZDist);

    void Update()
    {
        rotateSound(xAngle, yAngle, zAngle);
        translateSound(xDist, yDist, zDist);
    }

    void rotateSound(float xA, float yA, float zA)
    {
        float timedXAngle = xA * Time.deltaTime;
        float timedYAngle = yA * Time.deltaTime;
        float timedZAngle = zA * Time.deltaTime;
        toBeRotated.transform.Rotate(timedXAngle, timedYAngle, timedZAngle);

    }
    void translateSound(float xD, float yD, float zD)
    {
        float timedXDist = xDist * Time.deltaTime;
        float timedYDist = yDist * Time.deltaTime;
        float timedZDist = zDist * Time.deltaTime;
        toBeMoved.transform.Translate(xD, yD, zD);
    }
}
