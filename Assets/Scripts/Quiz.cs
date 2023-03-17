using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;
    [SerializeField] GameObject[] answerButtons;
    int correctAnswerIndex;
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;


    void Start()
    {
        questionText.text = question.GetQuestion();

        for ( int i = 0 ; i <= 3 ; i++ )
        {
            TextMeshProUGUI buttonText = answerButtons[i].  GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        }
    }
    public void OnAnswerSelected(int index) {
        {
            if (index == question.GetCorrectAnswerIndex())
            {
                questionText.text = "Correct!";
                Image buttonImage = answerButtons[index].GetComponent<Image>();
                buttonImage.sprite = correctAnswerSprite;
            }
            else
            {
                int correctAnswerIndex = question.GetCorrectAnswerIndex();
                questionText.text = question.GetAnswer(correctAnswerIndex);
                Image buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
                buttonImage.sprite = correctAnswerSprite;
            }
        }
    }

}
