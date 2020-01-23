using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClosePanel : MonoBehaviour
{
    public GameObject panel;
    public void closePanel()
    {
        panel.SetActive(false);
    }
}
