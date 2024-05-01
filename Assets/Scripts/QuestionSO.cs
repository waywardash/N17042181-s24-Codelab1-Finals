using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    // The question text. area making it bigger.
    [TextArea(2,6)]
    [SerializeField] private string question = "Enter new question text here";

    // An array to store multiple choice answers for the question.
    [SerializeField] private string[] answer = new string[3];

    // Index of the correct answer in the 'answer' array.
    [SerializeField] private int correctAnswerIndex;

    // Method to retrieve the question text.
    public string GetQuestion()
    {
        return question;
    }

    // Method to retrieve a specific answer by its index.
    public string GetAnswer(int index)
    {
        return answer[index];
    }

    // Method to retrieve the index of the correct answer.
    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
}