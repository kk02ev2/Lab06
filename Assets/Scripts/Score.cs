using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour

{
    public static Score Instance;
    private int score = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
    }

    // Update is called once per frame
    public void Addscore()
    {
        score++;
        Debug.Log("Your score is: " + score);
    }
}
