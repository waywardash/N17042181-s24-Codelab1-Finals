using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GetQuestion : MonoBehaviour
{
    // Serialized fields for inspector accessibility
    [SerializeField] TextMeshProUGUI questionText; // TextMeshProUGUI for displaying the question
    [SerializeField] QuestionSO question; // ScriptableObject containing the questions and answers
    [SerializeField] GameObject[] answerButtons; // Array of GameObjects representing answer buttons

    // Private variables
    private int correctAnswerIndex; // Index of the correct answer
    [SerializeField] Sprite defaultAnswerSprite; // Sprite for default answer button appearance
    [SerializeField] Sprite correctANswerSprite; // Sprite for correct answer button appearance

    // Start is called before the first frame update
    void Start()
    {
        // Display the question text retrieved from the QuestionSO
        questionText.text = question.GetQuestion();

        // Loop through answer buttons
        for (int i = 0; i < answerButtons.Length; i++)
        {
            // Get the TextMeshProUGUI component of the answer button
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            // Set the text of the answer button to the corresponding answer retrieved from the QuestionSO
            buttonText.text = question.GetAnswer(i);
        }
    }

    // Method called when an answer button is selected
    public void OnAnswerSelected(int index)
    {
        // Check if the selected answer index matches the index of the correct answer
        if (index == question.GetCorrectAnswerIndex())
        {
            // If correct, display "correct" text
            questionText.text = "correct";
            // Get the Image component of the selected answer button
            Image buttonImage = answerButtons[index].GetComponent<Image>();
            // Change the sprite of the selected answer button to the correct answer sprite
            buttonImage.sprite = correctANswerSprite;
        }
    }
}
