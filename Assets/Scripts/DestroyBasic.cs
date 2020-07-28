using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasic : MonoBehaviour
{

    // How to use the Destroy() function to remove GameObject and Components at runtime.

    /*
     * The destroy function can be used to remove GameObjects,
     *  or components from game objects at run time.
     */

    public GameObject other;

    // Update is called once per frame
    void Update()
    {
        // DESTROY BASIC
        if (Input.GetKey(KeyCode.LeftArrow))        
            Destroy(gameObject);

        // DESTROY BASIC WITH TIME DELAY
        if (Input.GetKey(KeyCode.RightArrow))
            Destroy(gameObject, 3f);

        // DESTROY OTHER
        if (Input.GetKey(KeyCode.DownArrow))
            Destroy(other);

        // DESTROY COMPONENT
        if (Input.GetKey(KeyCode.UpArrow))
            Destroy(GetComponent<MeshRenderer>());
    }
}
