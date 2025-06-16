using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI MinMaxGuess;
    [SerializeField] TextMeshProUGUI GuessText;


   [SerializeField] int minValue = 1;
   [SerializeField] int maxValue = 100;

    int currentminValue;
    int currentmaxValue;

    int guess;


    // Start is called before the first frame update
    void Start()
    {
        BeginGame();
    }

    void BeginGame()
    {
        //intro
        MinMaxGuess.text = ("You think of a number between " + minValue + " and " + maxValue);
        currentminValue = minValue;
        currentmaxValue = maxValue;

        Guess();
    }
    public void Higher()
    {
        currentminValue = guess;
        Guess();
    }
    public void Lower()
    {
        currentmaxValue = guess;
        Guess();
    }

    void Guess()
    {
        guess = Random.Range(currentminValue, currentmaxValue);

        GuessText.text = ("My guess is...                           " + guess);
    }

}

//I'm a genius