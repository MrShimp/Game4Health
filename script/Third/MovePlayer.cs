using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class MovePlayer : MonoBehaviour
{
    public bool tool1 = false;
    public bool tool2 = false;
    public bool tool3 = false;
    bool isMouseDown = false;
    bool isTheFinalShow = false;
    public GameObject Final_menu;
    public GameObject Van;
    public GameObject moveObj;
    private int status = 0;
    public Vector3 lastMousePosition;
    public bool ok = false;
    //public Image Van;



    void Awake() {
        Final_menu.SetActive(isTheFinalShow);
        print(Final_menu.active);
    }

    private void Start()
    {

    }

    void Update(){

        if (Input.GetMouseButtonDown(0))
        {
            isMouseDown = true;
            print(Input.mousePosition.x);
            if (Input.mousePosition.y >= 315 && Input.mousePosition.y <= 414)
            {
                print("In the 1");
                tool1 = true;
                moveObj = GameObject.Find("Tool1");
            }
            if (Input.mousePosition.y >= 185 && Input.mousePosition.y <= 287)
            {
                print("In the 2");
                tool2 = true;
                moveObj = GameObject.Find("Tool2");
            }
            if (Input.mousePosition.y >= 57 && Input.mousePosition.y <= 159)
            {
                print("In the 3");
                tool3 = true;
                moveObj = GameObject.Find("Tool3");
            }

        }
        if(Input.GetButton("Fire1")){

        }
        if (Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
            lastMousePosition = Vector3.zero;

        }
        if (isMouseDown)
        {
            //print(lastMousePosition);
            //print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            if (lastMousePosition != Vector3.zero)
            {
                Vector3 offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - lastMousePosition;
                moveObj.transform.position += offset * 25;
                
                //this.transform.position = lastMousePosition;
            }
            lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }


        if(status == 1){
            float step = 500 * Time.deltaTime;
            Van.transform.localPosition = Vector3.MoveTowards(Van.transform.localPosition, new Vector3(-31, -73, 50), step);
            //print("In the if");
            ok = true;
            Final_menu.SetActive(false);
        }

        if (status == 2)
        {
            Final_menu.SetActive(isTheFinalShow);

        }

        if (status == 3)
        {
            Final_menu.SetActive(isTheFinalShow);

        }
        //Final_menu.SetActive(isTheFinalShow);
        if(status == 1 && ok){
            Final_menu.SetActive(isTheFinalShow);
        }
    }



    void OnTriggerEnter2D(Collider2D c)
    {
        //Debug.Log();
        var target = GameObject.Find("Target");
        if (c.tag == "GetTargetDone")//c = be collapsed object
        {
            print("Touch the item");
            //Destroy the object
            //GameObject get object in the game
            //gameObject get the current object
            Destroy(target.gameObject);
            isTheFinalShow = true;
            print(isTheFinalShow);

            if (tool1)
            {

                status = 1;

            }
            if (tool2)
            {
                status = 2;
               
            }
            if (tool3)
            {

                status = 3;

            }
        }

    }
}
