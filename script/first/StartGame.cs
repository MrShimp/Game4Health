using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    int a=0, b=0, c=0;

    public Color show;

    private void Start()
    {
        show = new Color(a, b, c);
    }

    private void Update()
    {
        a++;
        b++;
        c++;
        show = new Color(a, b, c);
        print(show);
        this.GetComponent<Image>().color = show;
        if(a>255||b>255||c>255){
            a = 0;
            b = 0;
            c = 0;
        }
    }

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
