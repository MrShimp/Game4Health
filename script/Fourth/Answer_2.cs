using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Answer_2 : MonoBehaviour {

    public GameObject An1, An2, An3, Late;
    public Button Answer1, Answer2, Answer3;

    int Status = 0;
    // Use this for initialization
    void Start () {
        Late.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        Button btn1 = Answer1.GetComponent<Button>();
        Button btn2 = Answer2.GetComponent<Button>();
        Button btn3 = Answer3.GetComponent<Button>();

        btn1.onClick.AddListener(AnswerA);
        btn2.onClick.AddListener(AnswerB);
        btn3.onClick.AddListener(AnswerC);

        //print(Late.GetComponent<Rigidbody2D>().IsSleeping());

        if (Status == 1)
        {
            Answer2.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
            Answer3.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
            An1.GetComponent<Image>().color = Color.red;
            Late.GetComponent<Rigidbody2D>().WakeUp();
            Late.SetActive(true);


        }
        if (Status == 2)
        {
            Answer1.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
            Answer3.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
            An2.GetComponent<Image>().color = Color.green;
            Late.GetComponent<Rigidbody2D>().WakeUp();
            Late.SetActive(true);
        
            //van.transform.Translate(Vector3.left * 200 * Time.deltaTime);
        }
        if (Status == 3)
        {
            Answer2.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
            Answer1.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
            An1.GetComponent<Image>().color = Color.green;
            Late.GetComponent<Rigidbody2D>().WakeUp();
            Late.SetActive(true);
            //van.transform.Translate(Vector3.left * 200 * Time.deltaTime);
        }
    }
    void AnswerA()
    {
        Status = 1;
        //ToolPanel.SetActive(false);
        //van.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
    }
    void AnswerB()
    {
        Status = 2;

    }
    void AnswerC()
    {
        Status = 3;

    }
}
