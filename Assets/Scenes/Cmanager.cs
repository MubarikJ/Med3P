using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cmanager : MonoBehaviour
{
    public GameObject[] cameraWayPoints;
    public int cameraPositionIndicator = 0;
    public int lerpSpeed = 1;

    private void Start()
    {
        transform.position = cameraWayPoints[0].transform.position;

    }
    private void FixedUpdate()
    {
       
        transform.position = Vector3.Lerp(transform.position, cameraWayPoints[cameraPositionIndicator].transform.position, Time.deltaTime * lerpSpeed);
    }
}
