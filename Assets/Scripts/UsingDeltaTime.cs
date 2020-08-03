using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingDeltaTime : MonoBehaviour
    // What is Delta Time and how can it be used in your games to smooth and interpret values?
{
    /*
     * The term delta means a difference between two values
     * The DeltaTime property of the time class is essentially the time between each update
     *      or fixed update function call.
     * This can be used to smooth out values used for movement and other incremental calculations.
     * The time between frames is not constant.
     */

    public float Speed = 8f;
    public float Countdown = 3.0f;
        
    void Update()
    {
        Countdown -= Time.deltaTime;

        if (Countdown <= 0.0f)
            //light.enabled = true;

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(Speed + Time.deltaTime, 0.0f, 0.0f);        
    }
}
