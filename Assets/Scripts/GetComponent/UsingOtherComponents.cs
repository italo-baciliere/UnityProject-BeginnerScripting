using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
    // How to use the GetComponent function to address properties of other scripts or componentes.
{

    public GameObject OtherGameObject;

    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxColl;

    private void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = GetComponent<YetAnotherScript>();
        boxColl = OtherGameObject.GetComponent<BoxCollider>();
    }


    void Start()
    {
        boxColl.size = new Vector3(3, 3, 3);
        Debug.Log($"The player's score is {anotherScript.PlayerScore}");
        Debug.Log($"The player has died {yetAnotherScript.NumberOfPlayerDeaths} times");
    }
}
