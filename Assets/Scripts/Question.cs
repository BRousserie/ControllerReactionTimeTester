using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question
{
    public Button button;
    public float AnswerDelay;
    public bool IsCorrectAnswer;

    public Question()
    {
        button = ButtonsManager.Instance.GetRandomButton();
    }

    public Question(Button _button)
    {
        button = _button;
    }

    public void Answer(ButtonPosition answerPosition, float reactionTime)
    {
        AnswerDelay = reactionTime;
        IsCorrectAnswer = button.ButtonPosition == answerPosition;
    }
}