using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextLevel : MonoBehaviour
{
    private GameObject[] levelList;
    private int currentLevel = 1;
    void Start()
    {
        levelList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            levelList[i] = transform.GetChild(i).gameObject;
        }

        foreach (GameObject gameob in levelList)
        {
            gameob.SetActive(false);
        }
        levelList[currentLevel].SetActive(true);
    }

    public void toggleLevelmiddle(string direction)
    {
        foreach(GameObject gameob in levelList)
        {
            gameob.SetActive(false);
        }
        if (direction == "Right")
        {
            currentLevel++;
            if (currentLevel > levelList.Length - 1)
            {
                currentLevel = 0;
            }
        }
        else if (direction == "Left")
        {
            currentLevel--;
            if (currentLevel < 0)
            {
                currentLevel = levelList.Length - 1;
            }
        }
        levelList[currentLevel].SetActive(true);
    }

}

