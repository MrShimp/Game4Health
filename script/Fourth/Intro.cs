using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour {


    public GameObject girl1, bad1, bad2, girl2;
    public GameObject An1, An2, An3;
    public GameObject dialog1;
    //public GameObject dialog2;

    bool isCllap = false;
	// Use this for initialization
	void Awake () {
        dialog1.SetActive(false);
        An1.SetActive(false);
        An2.SetActive(false);
        An3.SetActive(false);
        print(An3);
        //dialog2.SetActive(false);


    }
	
	// Update is called once per frame
	void Update () {
        if(!isCllap){
            girl1.transform.Translate(Vector3.right * 50 * Time.deltaTime);
            bad1.transform.Translate(Vector3.right * 10 * Time.deltaTime);
            bad2.transform.Translate(Vector3.right * 10 * Time.deltaTime);
        }

    }

    void OnTriggerEnter2D(Collider2D c)     {         Debug.Log("Pengzhuangle");
        var item = GameObject.Find("Girl2");
        print(item);         if(c.tag == "Meet1")//c = be collapsed object         {             print("Collapse the item");
            dialog1.SetActive(true);
            isCllap = true;

            for (int i = 0; i < 1000;i++){

            }
            An1.SetActive(true);
            An2.SetActive(true);
            An3.SetActive(true);
            //Destroy the object
            //GameObject get object in the game
            //gameObject get the current object
            //Destroy(c.gameObject);
            //this.gameObject will destroy the object itself
        }      }

}
