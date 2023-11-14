

using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0F;
    public float rotationSpeed = 10.0F;


    GameObject character;
    private void FixedUpdate()
    {
        character.transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
    }
 

    void Update()
    {
        float translationV = Input.GetAxisRaw("Vertical") * speed;
        float translationH = Input.GetAxisRaw("Horizontal") * speed;



        // Arithemetic Operators using different style but mean the same thing
        translationV = translationV * Time.deltaTime;
        translationH *= Time.deltaTime;


        // ( X , Y, Z ) Axis Location Reference
        transform.Translate(0, 0, translationV);
        transform.Translate(translationH, 0, 0);


        //Right
        if (Input.GetAxisRaw("Horizontal") > 0)
        {



        }

        //Left
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {


        }

        //Up
        else if (Input.GetAxisRaw("Vertical") < 0)
        {



        }

        //Down
        else if (Input.GetAxisRaw("Vertical") < 0)
        {


        }


    }
}
