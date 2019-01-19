using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        GameStart();
    }

    void GameStart()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to the Number Wizard!");
        Debug.Log("Pick a number. but don't tell me what it is...");
        Debug.Log("The highest you can pick is: " + max);
        Debug.Log("The lowest is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = correct.");
        max++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Yay! I got it! Your number is " + guess);
            GameStart();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess);
    }
}
