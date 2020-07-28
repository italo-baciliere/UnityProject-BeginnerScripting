using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunctions : MonoBehaviour
{

    /*
     * Translate and Rotate are two functions that are commonly used
     *      to change the position and rotation of a GameObject
    */

    public float MoveSpeed = 10f;
    public float TurnSpeed = 50f;
    
    void Update()
    {
        /*
         * What we'd normally do with a Translate operation,
         *  is to multiply it by time.deltaTime.
         * 
         * Then, instead of saying Vector3(0, 0, 1)
         *  we can use Vector3.forward as a shortcut to this.
         */

        if (Input.GetKey(KeyCode.UpArrow))        
            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);        

        if (Input.GetKey(KeyCode.DownArrow))        
            transform.Translate(Vector3.back * MoveSpeed * Time.deltaTime);
            //transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);        

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -TurnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
    }
}
