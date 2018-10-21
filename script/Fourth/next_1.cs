using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class next_1 : MonoBehaviour {

    public void Click_Back()
    {
        StartCoroutine(Load());


    }
    IEnumerator Load()
    {

        AsyncOperation op = SceneManager.LoadSceneAsync("Fifth");
        yield return new WaitForEndOfFrame();
        op.allowSceneActivation = true;

    }
}
