using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Next : MonoBehaviour {


    public void Click_Back()
    {
        StartCoroutine(Load());


    }
    IEnumerator Load()
    {

        AsyncOperation op = SceneManager.LoadSceneAsync("Fourth");
        yield return new WaitForEndOfFrame();
        op.allowSceneActivation = true;

    }
}
