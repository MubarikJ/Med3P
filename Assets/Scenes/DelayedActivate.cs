using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedActivate : MonoBehaviour
{
    public GameObject objectToActivate;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(StartFunction());
    }

    private IEnumerator StartFunction()
    {
        //Wait for 5 sec.
        yield return new WaitForSeconds(5);

        //Turn My game object that is set to false(off) to True(on).
        objectToActivate.SetActive(true);
    }
}