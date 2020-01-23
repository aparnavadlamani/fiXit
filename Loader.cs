using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Loader : MonoBehaviour
{
    public Slider slider;
    public void LoadLevel(int sceneindex)
    {
        StartCoroutine(LoadAsynchronously(sceneindex));
    }
    IEnumerator LoadAsynchronously(int sceneindex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneindex);
        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null; 
        }
    }
}
