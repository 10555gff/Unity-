using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIinit : MonoBehaviour
{
    public Transform Canvas_ui;
    Button[] btns;
    string[] btn_name = { "F", "B", "R", "L", "U", "D",
                          "f", "b", "r", "l", "u", "d",
                          "y", "z", "x", "M", "S", "E"};
    //暂缓按钮的文本控件
    Text btn_contxt;
    //暂缓按钮的文本内容
    string t1;
    //按钮的类型
    public static int btn_type=1;

    float timeButton = 0;
    void Start()
    {
        //批量绑定Button
        btns = new Button[btn_name.Length];
        for (int i = 0; i < btn_name.Length; i++)
        {
            btns[i] = Canvas_ui.GetChild(i).GetComponent<Button>();
            btns[i].onClick.AddListener(btnOnClick);
        }
    }
    //Button事件组处理
    private void btnOnClick()
    {
        //每隔0.25f才能按一次
        if (timeButton < 0)
        {
            timeButton = 0.1f;
            t1 = EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name;
            switch (t1.Substring(t1.Length - 1, 1))
            {
                case "x":
                    GameManager.Instance.mofanBtnOnclick(t1.Substring(0, 1), GameManager.Axis.X);
                    break;
                case "y":
                    GameManager.Instance.mofanBtnOnclick(t1.Substring(0, 1), GameManager.Axis.Y);
                    break;
                case "z":
                    GameManager.Instance.mofanBtnOnclick(t1.Substring(0, 1), GameManager.Axis.Z);
                    break;
                case "o":
                    GameManager.Instance.mofanBtnOnclick(t1.Substring(0, 1), GameManager.Axis.O);
                    break;
            }
        }
    }

    void Update()
    {
        //魔方旋转类型转换
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            changeBtnText(2);
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            changeBtnText(1);
        }
        timeButton -= Time.deltaTime;
    }
    void changeBtnText(int type)
    {
        //要传参的按钮类型
        btn_type = type;
        //传参给类MofanMarkCreate改变标示符
        GameObject.Find("MarkCanvas").SendMessage("ChangMarkValue");
        //改变按钮文本
        for (int i = 0; i < btn_name.Length; i++)
        {
            //获取按钮的文本控件
            btn_contxt = btns[i].GetComponentInChildren<Text>();
            switch (type)
            {
                case 1:
                    btn_contxt.text = btn_name[i];
                    break;
                case 2:
                    btn_contxt.text = btn_name[i]+"'";
                    break;
            }
            
        }
    }

}
