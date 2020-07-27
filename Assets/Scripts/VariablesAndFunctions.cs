using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{

    int myInt = 5;

    void Start()
    {
        myInt = MultiplayByTow(myInt);
        Debug.Log(myInt);
    }

    int MultiplayByTow(int number){
        number *= 2;
        return number;
    }
}
