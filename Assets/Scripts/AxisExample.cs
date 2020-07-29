using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisExample : MonoBehaviour
{

    /*
     * GetAxis return a float value between -1 and 1.
     */

    public float range;
    public GUIText textOutput;
    
    void Start()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned:" + h.ToString("F2");
    }
}
