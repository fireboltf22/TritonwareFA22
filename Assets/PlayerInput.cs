using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    private string input;
    private string spell = "fire";

    public static string keyboardText = "";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("enter")) {
            if (string.Equals(input, spell)) {
                Debug.Log("You casted fire.");
            }
            input = "";
        }
        Debug.Log(input);
    }

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }

}
