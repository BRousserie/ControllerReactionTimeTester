using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PlayerInput))]
public class TestManager : MonoBehaviour
{
    public ButtonsManager ButtonsManager;
    public bool OneByOne;
    public int AnswersWanted = 15;
    public int QueueSize = 5;
    
    private ITest test;

    private void Start()
    {
        test = (OneByOne) ? (ITest) new OneByOneTest(this) : new QueuingTest(this);
        test.StartTest();
    }

    public void OnUp(InputAction.CallbackContext context) { if (context.performed) test.SendAnswer(ButtonPosition.Up); }
    public void OnDown(InputAction.CallbackContext context) { if (context.performed) test.SendAnswer(ButtonPosition.Down); }
    public void OnLeft(InputAction.CallbackContext context) { if (context.performed) test.SendAnswer(ButtonPosition.Left); }
    public void OnRight(InputAction.CallbackContext context) { if (context.performed) test.SendAnswer(ButtonPosition.Right); }
}

public abstract class ITest
{
    public List<Question> Questions = new List<Question>();
    protected int answersDone = 0;
    protected TestManager testManager;
    private float buttonPressedTime = 0;

    public ITest(TestManager _testManager)
    {
        testManager = _testManager;
    }
    
    public abstract void StartTest();

    public void SendAnswer(ButtonPosition answer)
    {
        float reactionTime = Time.time - buttonPressedTime;
        if (Questions.Count > 0) // this test allows to show a first button which doesn't count as a question
            Questions[answersDone++].Answer(answer, reactionTime);

        buttonPressedTime = Time.time;
        
        if (answersDone < testManager.AnswersWanted) Next();
        else SaveResults();
    }
    public abstract void Next();

    public void SaveResults()
    {
        UserData userData = GameObject.FindObjectOfType<UserData>();
        string subject = userData.Name + "'s Reaction Time Test";
        string body = String.Concat(userData.Name, ";", userData.Controller, "\n");

        int i = 0;
        foreach (Question question in Questions)
        {
            body += String.Concat( ++i, ";", 
                question.button.IconType.ToString(), ";", 
                question.button.ButtonPosition.ToString(), ";",
                question.AnswerDelay, ";",
                question.IsCorrectAnswer, "\n");
        }
        
        Debug.Log(body);
        SendToFile(subject, body);
        Email.SendClara(subject, body);
        SceneManager.LoadScene(0);
    }

    private void SendToFile(string subject, string body)
    {
        File.WriteAllText (subject + ".csv", body);
    }
}

public class OneByOneTest : ITest
{
    private ButtonDisplayer buttonDisplayer;
    
    public OneByOneTest(TestManager _testManager) : base(_testManager)
    {
        buttonDisplayer = testManager.GetComponentInChildren<ButtonDisplayer>();
    }
    
    public override void StartTest()
    {
        buttonDisplayer.SetSprite(testManager.ButtonsManager.GetFirstButton().Sprite);
    }

    public override void Next()
    {
        Questions.Add(new Question());
        buttonDisplayer.SetSprite(Questions.Last().button.Sprite);
    }
}

public class QueuingTest : ITest
{
    private ButtonDisplayersQueue displayersQueue;
    private int sequence = 0;
    private int target = 0;
        
    public QueuingTest(TestManager _testManager) : base(_testManager)
    {
        GameObject newButtonDisplayerQueue = new GameObject(
            "ButtonDisplayerQueue", typeof(ButtonDisplayersQueue));
        newButtonDisplayerQueue.transform.parent = testManager.transform;
        displayersQueue = newButtonDisplayerQueue.GetComponent<ButtonDisplayersQueue>();
        displayersQueue.CreateButtonDisplayers(testManager.QueueSize);
    }
    
    public override void StartTest()
    {
        Debug.Log("Starting test");
        for (int questionIndex = 0; questionIndex < testManager.QueueSize; ++questionIndex)
            displayersQueue.SetSprite(questionIndex, ButtonsManager.Instance.GetFirstButton().Sprite);
    }

    public override void Next()
    {
        displayersQueue.SetDone(target);
        if (++target == testManager.QueueSize)
        {
            target = 0;
            InitSequence();
        }
    }

    private void InitSequence()
    {
        if (sequence == 0) answersDone = 0; // allows us to create a first sequence for test
        
        IconType iconType = (IconType) sequence++;
        for (int questionIndex = 0; questionIndex < testManager.QueueSize; ++questionIndex)
        {
            Button nextButton = ButtonsManager.Instance.GetRandomButton(iconType);
            displayersQueue.SetSprite(questionIndex, nextButton.Sprite);
            Questions.Add(new Question(nextButton));
        } 
    }
}