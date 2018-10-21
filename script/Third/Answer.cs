using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour {

    public GameObject An1, An2, An3,Late,Late2;
    public Button Answer1, Answer2, Answer3;

    public GameObject van;
    private Vector3 force = Vector3.forward * 10.0f;

    //public Rigidbody2D vanRe;
    //public GameObject Result;
    //public Rigidbody2D Result;
    int Status = 0;
    private bool sleeping,sleeping1;

    // Use this for initialization
    void Start () {
        //Result = Late.AddComponent<Rigidbody2D>();
        //Result.Sleep();
       // Result.mass = 1000.0f;
      //  Physics.gravity = new Vector3(0, -10000.0f, 0);
        sleeping = false;
        //fallTime = 0.0f;
        Late.GetComponent<Rigidbody2D>().Sleep();
        Late.SetActive(false);
        Late2.SetActive(false);
        // print(Result.IsSleeping());
        //vanRe = van.AddComponent<Rigidbody2D>();
        //vanRe.mass = 10.0f;
        //Physics.gravity = new Vector3(0, 0, 0);
        van.GetComponent<Rigidbody2D>().drag = 0.3f;
        van.SetActive(false);
        //sleeping1 = true;

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

        if (Status == 1&&sleeping){
            Answer2.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
            Answer3.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
            An1.GetComponent<Image>().color = Color.red;
            Late.GetComponent<Rigidbody2D>().WakeUp();
            Late.SetActive(true);
            van.SetActive(true);
            van.transform.Translate(Vector3.left * 200 * Time.deltaTime);
            van.GetComponent<Rigidbody2D>().AddForce(force);
            van.GetComponent<Rigidbody2D>().WakeUp();
            GameObject.Find("Target").SetActive(false);
            GameObject.Find("Player").SetActive(false);

        }
        if (Status == 2 && sleeping)
        {
            Answer1.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
            Answer3.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
            An2.GetComponent<Image>().color = Color.green;
            Late2.GetComponent<Rigidbody2D>().WakeUp();
            Late2.SetActive(true);
            //Late.GetComponent<Rigidbody2D>().WakeUp();
            //Late.SetActive(true);
            van.SetActive(true);
            //van.transform.Translate(Vector3.left * 200 * Time.deltaTime);
        }
        if (Status == 3 && sleeping)
        {
            Answer2.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
            Answer1.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
            An1.GetComponent<Image>().color = Color.green;
            Late2.GetComponent<Rigidbody2D>().WakeUp();
            Late2.SetActive(true);
            van.SetActive(true);
            //van.transform.Translate(Vector3.left * 200 * Time.deltaTime);
        }



    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds(3.0f);
    }

    void AnswerA(){
        Status = 1;
        sleeping = true;
        //ToolPanel.SetActive(false);
        //van.transform.Translate(Vector3.left * 1000 * Time.deltaTime);
    }
    void AnswerB() {
        Status = 2;
        sleeping = true;

    }
    void AnswerC() {
        Status = 3;
        sleeping = true;

    }

    private void OnMouseEnter()
    {
        An1.GetComponent<Image>().color = Color.red;
        An2.GetComponent<Image>().color = Color.red;
        An3.GetComponent<Image>().color = Color.red;
    }

}
