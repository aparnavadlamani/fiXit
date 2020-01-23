using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level1 : MonoBehaviour
{
    int flag1 = 0;
    int flag2 = 0;
    int score = 100;
    public GameObject panel;
    public GameObject panel1;
    public GameObject image1;
    public GameObject image2;
    public InputField input1;
    public InputField input2;
    public GameObject imagebulb1;
    public GameObject imagebulb2;
    public GameObject PlayB;
    public GameObject panel2;
    public GameObject panel3;
    public Text scorey;
    int buttonindex;
    public void Button1()
    {
        panel.SetActive(true);
        buttonindex = 1;
        flag1 = 1;
    }
    public void Button2()
    {
        panel.SetActive(true);
        buttonindex = 2;
        flag2 = 1;
    }
    public void closePanel(int index)
    {
        if(index==0)
            panel3.SetActive(false);
        if (index == 1)
            panel.SetActive(false);
    }
    public void xorButton()
    {
        if(buttonindex==1)
        {
            image1.SetActive(true);
        }
        else
        {
            score -= 2;
        }
    }
    public void IUnderstoodButton()
    {
        if(flag1==1&&flag2==1)
        {
            panel2.SetActive(true);
            scorey.text = score + "";
        }
    }
    public void selectLevelButton()
    {
        panel2.SetActive(false);
        SceneManager.LoadScene(1);
    }
    public void andButton()
    {
        if(buttonindex==2)
        {
            image2.SetActive(true);
        }
        else
        {
            score -= 2;
        }
    }
    public void nextButton()
    {
        panel1.SetActive(false);
        panel3.SetActive(true);
    }
    public void DoneButton()
    {
        if(flag1==1&&flag2==1)
            PlayB.SetActive(true);
    }
    public void PlayButton()
    {
        if(input1.text=="0"&&input2.text=="1")
        {
            imagebulb1.SetActive(true);
            imagebulb2.SetActive(false);
        }
        if (input1.text == "1" && input2.text == "0")
        {
            imagebulb1.SetActive(true);
            imagebulb2.SetActive(false);
        }
        if (input1.text == "0" && input2.text == "0")
        {
            imagebulb1.SetActive(false);
            imagebulb2.SetActive(false);
        }
        if (input1.text == "1" && input2.text == "1")
        {
            imagebulb1.SetActive(false);
            imagebulb2.SetActive(true);
        }

    }
}
