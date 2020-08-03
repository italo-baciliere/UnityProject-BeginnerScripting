using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScritpt : MonoBehaviour
{
    /*
     * Learn the important differences between Value and Reference data types, in order
     * to better understand how variables work.
     */    
    void Start()
    {
        // Value type variable
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);

        // Reference type variable
        Transform tran = transform;
        tran.position = new Vector(0, 2, 0); // this move the reference object.
    }    
}
