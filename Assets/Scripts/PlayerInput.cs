using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{

    private string input = "";
    public InputField clear;
    public GameObject pauseMenu;
    private string[] spells = {"fire", "ice", "water", "rock", "shock"};
    private bool correctSpell = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Escape)) {
            TogglePauseMenu();
        }
        if(Time.timeScale == 1) {
            for(int i=0; i<spells.Length; i++){
                if (string.Equals(input, spells[i])) {
                    Debug.Log("You casted " + spells[i] + ".");
                    correctSpell = true;
                }
            }
            if (!(string.Equals(input, "")) && (correctSpell == false)) {
                Debug.Log("You messed up your spell and turned into a frog.");
            }
            input = "";
            correctSpell = false;
            clear.ActivateInputField();
        }
        
    }

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
        clear.text = "";
    }

    void OnGUI() {
        if (Time.timeScale == 0){
            pauseMenu.SetActive(true);
        } else {
            pauseMenu.SetActive(false);
        }
    }

    public void TogglePauseMenu() {
        Debug.Log("Escape key was pressed.");
        if (Time.timeScale == 0) {
            Time.timeScale = 1;
        } else {
            Time.timeScale = 0;
        }
    }

}
