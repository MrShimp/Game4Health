using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToolButton : MonoBehaviour {

    public GameObject HitMen,OpMen;
    bool OpMen_isshow = false;
    bool hint_isshow = false;
    // Use this for initialization
    void Start () {
        //Tool_menu = GameObject.Find("ToolPanel")
        //Calls the TaskOnClick/TaskWithParameters method when you click the Button
        //print(Tool_menu);
        //print(Tool_menu.active);
    }

    // Update is called once per frame
    void Update () {

        if(hint_isshow){
            HitMen.SetActive(hint_isshow);
           
        }
        if(OpMen_isshow){
            OpMen.SetActive(OpMen_isshow);
        }

    }

    public void clickhitbtn()
    {
        hint_isshow = true;
    }

    public void clickOpbtn()
    {
        OpMen_isshow = true;
    }


}
