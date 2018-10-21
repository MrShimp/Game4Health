using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {

    public void Click_Back()
    {
        StartCoroutine(Load());


    }
    IEnumerator Load()
    {

        AsyncOperation op = SceneManager.LoadSceneAsync("Third");
        yield return new WaitForEndOfFrame();
        op.allowSceneActivation = true;

    }
}
