using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public TMP_Text HPCounter;

    static public int health = 5;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHP();
    }

    //Update is called once every frame
    void Update()
    {
        UpdateHP();
    }

    void UpdateHP(){
        HPCounter.text = health.ToString();
        //If HP <= 0, GAME OVER
    }
}
