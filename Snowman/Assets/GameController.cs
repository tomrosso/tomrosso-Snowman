using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;
public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;
    public UnityEngine.UI.Button PlayAgain;
    public UnityEngine.UI.Text CorrectWord;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    private WordGuesser.WordGame guessingGame;
    public UnityEngine.UI.InputField PlayerGuess;
    public UnityEngine.UI.Text HiddenLetters;
    public UnityEngine.UI.Text LettersGuessed;
    public UnityEngine.UI.Text NumberOfGuessesLeft;
    public UnityEngine.UI.Text CheckGuess;
    public UnityEngine.UI.Text GameOver;


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
        this.DisplayHiddenLetters();
        this.DisplayLettersGuessed();
        this.DisplayNumberOfGuessesLeft();
        this.DisplayCheckGuess(PlayerGuess.text);
        
        PlayerGuess.text = string.Empty;

    }
    public void DisplayHiddenLetters()
    {
        HiddenLetters.text = this.guessingGame.GetWord();
    }
    public void DisplayLettersGuessed()
    {
        LettersGuessed.text = this.guessingGame.GetGuessedLetters();
    }
    public void DisplayNumberOfGuessesLeft()
    {
        NumberOfGuessesLeft.text = $"{this.guessingGame.GetGuessLimit() - this.guessingGame.GetIncorrectGuesses()}";
    }
    public void DisplayCheckGuess(string guess)
    {
        CheckGuess.text = "Your guess is: " + this.guessingGame.CheckGuess(guess);
    }
    public void DisplayGameOver()
    {
        GameOver.text = "You Lost";
    }
    public void DisplayCorrectWord();
    {
        CorrectWord.text = "apple";
    }

}
