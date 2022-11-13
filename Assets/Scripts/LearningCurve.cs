using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 30;
    public string Firstname = "Harrison";
    // Start is called before the first frame update
    void Start()
    {
        int characterLevel = 31;
        Debug.Log("Choose a character");
        GenerateCharacter("Spike", characterLevel);
        Debug.Log("Nice choice");
    }

    // Update is called once per frame
    /// <summary>
    /// 
    /// </summary>
    void Update()
    {
        
    }

    public void GenerateCharacter(string name, int level)
    {

        Debug.LogFormat("Character:{0} - Level:{1}", name, level);
    }
}
