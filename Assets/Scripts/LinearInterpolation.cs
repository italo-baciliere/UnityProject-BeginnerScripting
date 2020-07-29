using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{

    /*
     * When making games it can sometimes be useful to linearly interpolate between two values. 
     *  This is done with a function called Lerp.
     * Linearly interpolating is finding a value that is some percentage between two given values. 
     *  For example, we could linearly interpolate between the numbers 3 and 5 by 50% to get the number 4. 
     *  This is because 4 is 50% of the way between 3 and 5.
     */

    // Start is called before the first frame update
    void Start()
    {
        // In this case, result = 4
        float result = Mathf.Lerp(3f, 5f, 0.5f);
    }    
}
