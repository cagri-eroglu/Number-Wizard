using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameFlow : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] int guess;
    [SerializeField] TextMeshProUGUI guesstext;

    private void Start()
    {
        guess = Random.Range(min,max+1);
        guesstext.text = guess.ToString();
    }
    private void Update()
    {
        
    }
    private void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guesstext.text = guess.ToString();
    }
    public void OnPressHigher()
    {
        max = guess + 1;
        NextGuess();
    }
   
    public void onPressLower()
    {
        min = guess - 1;
        NextGuess();
    }
}
