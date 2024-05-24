using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int monsterCount;
    private int point = 0;


    void Start()
    {
        // �ʱ� ���� �� ����
        monsterCount = GameObject.FindGameObjectsWithTag("Monster").Length;
        Debug.Log("Initial Monster Count: " + monsterCount);
    }

    public void DecreaseCount()
    {
        monsterCount--;
        point++;
        Debug.Log("Ponit: "+ point);
        Debug.Log("Remaining Monster Count: " + monsterCount);

        if (monsterCount <= 0)
        {
            Debug.Log("Level Cleared");
        }
    }
}
