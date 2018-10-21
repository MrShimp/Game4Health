using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeContent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click_Back()
    {
        StartCoroutine(Load());


    }
    public void Click_Back1()
    {
        StartCoroutine(Load1());


    }
    public void Click_Back2()
    {
        StartCoroutine(Load2());


    }
    IEnumerator Load()
    {

        AsyncOperation op = SceneManager.LoadSceneAsync("Third");
        yield return new WaitForEndOfFrame();
        op.allowSceneActivation = true;

    }

    IEnumerator Load1()
    {

        AsyncOperation op = SceneManager.LoadSceneAsync("Fourth");
        yield return new WaitForEndOfFrame();
        op.allowSceneActivation = true;

    }
    IEnumerator Load2()
    {

        AsyncOperation op = SceneManager.LoadSceneAsync("Fifth");
        yield return new WaitForEndOfFrame();
        op.allowSceneActivation = true;

    }
}
