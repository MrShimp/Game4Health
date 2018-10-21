using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_1 : MonoBehaviour {
    public GameObject An1, An2, An3;
    public GameObject dialog1;

    int dialogue_index = 0;
    bool isCllap = false;
    // Use this for initialization
    void Awake()
    {
        dialog1.SetActive(false);
        An1.SetActive(false);
        An2.SetActive(false);
        An3.SetActive(false);
        print(An3);
        //dialog2.SetActive(false)
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))//如果点击了鼠标左键
        {

            dialog1.SetActive(true);//那就载入下一条对话

            if (dialogue_index > 0)
            {
                An1.SetActive(true);
                An2.SetActive(true);
                An3.SetActive(true);
            }
            dialogue_index++;
        }
    }
}
