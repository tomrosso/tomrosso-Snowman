using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;
public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;

    public UnityEngine.UI.Text HiddenLetters;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    private WordGuesser.WordGame guessingGame;
    public UnityEngine.UI.InputField PlayerGuess;


    public void StartGame()
    {
        this.guessingGame = new WordGuesser.WordGame("apple", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());

        this.StartScreen.gameObject.SetActive(false);
        this.PlayScreen.gameObject.SetActive(true);
    }
    public void OpenStartScreen()
    {
        this.StartScreen.gameObject.SetActive(true);
        this.PlayScreen.gameObject.SetActive(false);
    }
    public void Start()
    {
        this.StartScreen.gameObject.SetActive(true);
        this.PlayScreen.gameObject.SetActive(false);
    }
    public void SubmitGuess()
    {
        Debug.Log(this.guessingGame.CheckGuess(this.PlayerGuess.text));
        PlayerGuess.text = string.Empty;

    }
}
