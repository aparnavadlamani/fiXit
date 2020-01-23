using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class level2 : MonoBehaviour
{
    int flag1 = 0;
    int flag2 = 0;
    int flag3 = 0;
    int flag4 = 0;
    int flag5 = 0;
    public GameObject panel;//description panel
    public GameObject panel1;//components panel
    public GameObject image1;//xor
    public GameObject image2;//xor
    public GameObject image3;//and
    public GameObject image4;//and
    public GameObject image5;//or
    public InputField input1;//A
    public InputField input2;//B
    public InputField input3;//C
    public GameObject imagebulb1;//Sum
    public GameObject imagebulb2;//carry
    public GameObject playbutton;
    public GameObject panel2;
    public GameObject panel3;
    public Text scorey;
    int score = 100;

    int buttonindex;
    public void closePanel(int index)
    {
        if (index == 0)
            panel3.SetActive(false);
        if (index == 1)
            panel.SetActive(false);
    }
    public void nextButton()
    {
        panel1.SetActive(false);
        panel3.SetActive(true);
    }
    public void IUnderstoodButton()
    {
        if(flag1==1&&flag2==1&&flag3==1&&flag4==1&&flag5==1)
        {
            panel2.SetActive(true);
            scorey.text = score + "";
        }
    }
    public void selectLevelButton()
    {
        SceneManager.LoadScene(1);
    }
    public void Button1()
    {
        panel.SetActive(true);
        buttonindex = 1;
        flag1 = 1;
    }
    public void Button2()
    {
        panel.SetActive(true);
        buttonindex = 1;
        flag2 = 1;
    }
    public void Button3()
    {
        panel.SetActive(true);
        buttonindex = 2;
        flag3 = 1;
    }
    public void Button4()
    {
        panel.SetActive(true);
        buttonindex = 2;
        flag4 = 1;
    }
    public void Button5()
    {
        panel.SetActive(true);
        buttonindex = 3;
        flag5 = 1;
    }
    public void xorButton()
    {
        if(buttonindex==1&&flag1==1)
        {
            image1.SetActive(true);
        }
        if(buttonindex==1&&flag2==1)
        {
            image2.SetActive(true);
        }
        else
        {
            score -= 2;
        }
    }
    public void andButton()
    {
        if (buttonindex == 2&&flag3==1)
        {
            image3.SetActive(true);
        }
        if(buttonindex==2&&flag4==1)
        {
            image4.SetActive(true);
        }
        else
        {
            score -= 2;
        }
    }
    public void orButton()
    {
        if (buttonindex == 3)
        {
            image5.SetActive(true);
        }
        else
        {
            score -= 2;
        }
    }
    public void DoneButton()
    {
        if (flag1 == 1 && flag2 == 1 && flag3==1 && flag4==1 && flag5==1)
            playbutton.SetActive(true);
    }
    public void PlayButton()
    {
        if (input1.text == "0" && input2.text == "0" && input3.text=="0")
        {
            imagebulb1.SetActive(false);
            imagebulb2.SetActive(false);
        }
        if (input1.text == "0" && input2.text == "0" && input3.text=="1")
        {
            imagebulb1.SetActive(true);
            imagebulb2.SetActive(false);
        }
        if (input1.text == "0" && input2.text == "1" && input3.text == "0")
        {
            imagebulb1.SetActive(true);
            imagebulb2.SetActive(false);
        }
        if (input1.text == "0" && input2.text == "1" && input3.text == "1")
        {
            imagebulb1.SetActive(false);
            imagebulb2.SetActive(true);
        }
        if (input1.text == "1" && input2.text == "0" && input3.text == "0")
        {
            imagebulb1.SetActive(true);
            imagebulb2.SetActive(false);
        }
        if (input1.text == "1" && input2.text == "0" && input3.text == "1")
        {
            imagebulb1.SetActive(false);
            imagebulb2.SetActive(true);
        }
        if (input1.text == "1" && input2.text == "1" && input3.text == "0")
        {
            imagebulb1.SetActive(false);
            imagebulb2.SetActive(true);
        }
        if (input1.text == "1" && input2.text == "1" && input3.text == "1")
        {
            imagebulb1.SetActive(true);
            imagebulb2.SetActive(true);
        }
    }
}
