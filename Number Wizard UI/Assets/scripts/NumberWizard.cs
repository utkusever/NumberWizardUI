using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max; // degerler class'a alındı ki update metodu da erişebilsin.
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {

        calc();

    }

    public void OnPressHigher()
    {
        min = guess +1 ;
        calc();
    }
    public void OnPressLower()
    {
        max = guess -1;
        calc();
    }

    void calc()
    {
        guess = Random.Range(min, max); //min inclue max exclue
        guessText.text = guess.ToString();
    }
    
}
