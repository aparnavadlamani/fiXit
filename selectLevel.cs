using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class selectLevel : MonoBehaviour
{
    private GameObject[] levelList;
    protected int currentLevel = 0;
    void Start()
    {
        levelList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            levelList[i] = transform.GetChild(i).gameObject;
        }

        foreach(GameObject gameob in levelList)
        {
            gameob.SetActive(false);
        }
        levelList[0].SetActive(true);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void changeLevel()
    {
        SceneManager.LoadScene(currentLevel + 2);
    }
    public void toggleLevelmiddle(string direction)
    {
        //levelList[currentLevel].SetActive(false);
        foreach (GameObject gameob in levelList)
        {
            gameob.SetActive(false);
        }
        if (direction == "Right")
        {
            currentLevel++;
            if(currentLevel > levelList.Length - 1)
            {
                currentLevel = 0;
            }
        }
        else if(direction == "Left")
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


