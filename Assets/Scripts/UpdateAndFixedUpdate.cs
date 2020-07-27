using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    /*
    * How to effect changes every frame with the Update and FixedUpdate functions,
    * and their differences.
    */

    private void FixedUpdate()
    {
        // Called every physics step
        // FixedUpdate intervals are consistent
        /* Used for regular updates such as:
                Adjusting physics (Rgidbody) objects */

        Debug.Log("FixedUpdate time: " + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        // Called every frame
        /* Used for regular updates such as:
         *  Moving non-physics objects
         *  Simple Timers
         *  Receiving Input*/

        // Update internal times vary

        Debug.Log("Update time: " + Time.deltaTime);
    }    

}