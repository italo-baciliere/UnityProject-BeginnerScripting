using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{

    /*
     * Awake and Start are two functions that are
     * called automatically when a script is loaded.
     * 
     * Aware is called first even if the script component
     * is not enabled and is best used for setting up
     * any references between scripts and initialization.
     * 
     * Star is called after Awake, immedialtely before the
     * first update.
     * But only if the script component is enabled.
     * This means that you can use start for anything you need
     * to occur when the script component is enabled.
     */

    void Awake()
        // Set Ammo for the enemy
    {
        Debug.Log("Awake called.");
    }

    void Start()
        // Allow enemy to Shoot
    {
        Debug.Log("Start called.");
    }        
}
