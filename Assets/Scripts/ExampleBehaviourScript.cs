using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehaviourScript : MonoBehaviour
{
    Renderer Cube;
    
    // Start is called before the first frame update
    void Start()
    {
        Cube = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Cube.material.color = Color.HSVToRGB(0, 98, 95);
        }        
        if (Input.GetKey(KeyCode.G))
        {            
            Cube.material.color = Color.HSVToRGB(116, 47, 79);
        }
        if (Input.GetKey(KeyCode.B))
        {            
            Cube.material.color = Color.HSVToRGB(0, 98, 75);
        }
    }
}
