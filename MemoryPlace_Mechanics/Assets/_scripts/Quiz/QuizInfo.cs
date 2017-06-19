using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizInfo : MonoBehaviour {
    public ItemManager itemManager;
    public List<bool> askedQuestion;
    public int NumberOfQuestions;
	// Use this for initialization
	void Start () {
        NumberOfQuestions = itemManager.objectsToPlace.Length;
        for (int i = 0; i < NumberOfQuestions;i++)
        {
            askedQuestion.Add(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void askRandomQuestion()
    {
        int minRange = 0;
        int maxRange = NumberOfQuestions;
        int random = Random.Range(minRange, maxRange);
        if (askedQuestion[random] == true)
        {
             random = Random.Range(minRange, maxRange);

        }

    }
}
