using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_2 : MonoBehaviour {
    public void Click_Back()
    {
        StartCoroutine(Load());


    }
    IEnumerator Load()
    {

        AsyncOperation op = SceneManager.LoadSceneAsync("second");
        yield return new WaitForEndOfFrame();
        op.allowSceneActivation = true;

    }
}
