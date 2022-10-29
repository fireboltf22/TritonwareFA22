using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public TMP_Text scoreCounter;

    private int currLevel;
    public GameObject[] levels;

    private const int LEVEL_1_SCORE = 50;
    private const int LEVEL_2_SCORE = 100;
    private const int LEVEL_3_SCORE = 150;

    public int score;
    public int scoreIncrementer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    /**
     * Checks which inputs the player is pressing and calls the appropriate methods
     */
    void GetInput()
    {
        if(Input.GetButtonDown("Jump"))
        {
            AddScore();
        }
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Upgrade();
        }
        if(Input.GetMouseButtonDown(0)){
            foreach (GameObject level in levels){
                level.SetActive(false);
            }
        }
    }

    /**
     * FOR TESTING PURPOSES: Increments score
     * LATER: Update this so that it takes an int argument for
     * the score to increment by
     * LATER: In enemy scripts, call this method with the enemy's score value
     */
    public void AddScore()
    {
        score += 1 + scoreIncrementer;
        UpdateScore();
    }

    void UpdateScore(){
        scoreCounter.text = score.ToString();
        //LATER: Clone this code for the rest of the levels
        if (score >= LEVEL_1_SCORE && currLevel == 0){
            currLevel++;
            levels[currLevel].SetActive(true);
        }
        if (score >= LEVEL_2_SCORE && currLevel == 1){
            currLevel++;
            levels[currLevel].SetActive(true);
        }
        if (score >= LEVEL_3_SCORE && currLevel == 2){
            currLevel++;
            levels[currLevel].SetActive(true);
        }
    }

    /**
     * FOR TESTING PURPOSES: Increments score incrementer
     */
    void Upgrade()
    {
        scoreIncrementer += 1;
        Debug.Log(scoreIncrementer);
    }
}
