using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObjects : MonoBehaviour
{

    /*
     * How to handle the active status of GameObject in the scene, both independently 
     * and within Hierarchies, using SetActive and activeSelf / activeHierarchy.
     */
    
    void Start()
    {
        // ACTIVE OBJECTS
        gameObject.SetActive(false);

        // CHECK STATE
        Debug.Log("Active Self: " + gameObject.activeSelf);
        Debug.Log("Active in Hierarchy: " + gameObject.activeInHierarchy);
    }
}
