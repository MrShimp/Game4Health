using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml;
using System.Collections.Generic;

public class readdialog : MonoBehaviour {

    //这是场景中的各个物体


    private GameObject TargetDialog;

    private int dialogue_index = 0;//对话索引

    private string d;
    public GameObject Tool_Obj1, Tool_Obj2, Tool_Obj3;
    public GameObject HitMenu;
    bool panel_isshow = false;


    private void Awake()
    {
        TargetDialog = GameObject.Find("Canvas/dialog");
        //print(PlayerDialog);

        print(TargetDialog);
        //roleName = GameObject.Find("Canvas/Image/roleName");


        TargetDialog.SetActive(false);
    }
    void Start()
    {
        //Tool_menu = GameObject.Find("ToolPanel");
        Tool_Obj1.SetActive(panel_isshow);
        Tool_Obj2.SetActive(panel_isshow);
        Tool_Obj3.SetActive(panel_isshow);
        //Calls the TaskOnClick/TaskWithParameters method when you click the Button




    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))//如果点击了鼠标左键
        {

            TargetDialog.SetActive(true);//那就载入下一条对话

            if (dialogue_index > 0)
            {
                Tool_Obj1.SetActive(true);
                Tool_Obj2.SetActive(true);
                Tool_Obj3.SetActive(true);
            }
            dialogue_index++;
        }



    }




}
