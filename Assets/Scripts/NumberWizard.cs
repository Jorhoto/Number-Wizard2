using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] private int min;
    [SerializeField] private int max;
    [SerializeField] private Text guessText;
    private int guessNumber;


    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ResetGame()
    {
        guessNumber = Random.Range(min, max);
        guessText.text = guessNumber.ToString();
    }

    public void OnPressHigher()
    {
        ResetGame();
    }

    public void OnPressLower()
    {
        ResetGame();
    }





}
