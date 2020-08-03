using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
    // How to detect mouse clicks on a Collider or GUI element.
{
    private Rigidbody rd;

    private void Awake()
    {
        rd = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        rd.AddForce(-transform.forward * 500f);
        rd.useGravity = true;
    }
}