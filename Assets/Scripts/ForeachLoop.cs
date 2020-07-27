using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour
{

    string[] strings = new string[3];

    // Start is called before the first frame update
    void Start()
    {       
        strings[0] = "First String";
        strings[1] = "Secund String";
        strings[2] = "Third String";
    }

    // Update is called once per frame
    void Update()
    {
        foreach (string strg in strings)
        {
            Debug.Log(strg);
        }
    }
}