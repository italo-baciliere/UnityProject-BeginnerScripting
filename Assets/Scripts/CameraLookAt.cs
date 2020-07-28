using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{

    /*
     * LookAt can be used to make a GameObject's forward direction
     *  point at another transform in the world
     */

    public Transform Target;
        
    void Update()
    {
        /*
         * We can use the transform.LookAt function
         *  to tell our object to look at the target
         */
        transform.LookAt(Target);
    }
}
