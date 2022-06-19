using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MofanRestore : MonoBehaviour
{
    public static MofanRestore Instance = null;
    int n;
    string mofanColor;
    string str;
    string[] mofanPosArr = { "ULF", "UL", "UBL", "UB", "URB", "UR", "UFR", "UF" };
    private void Start()
    {
        Instance = this;
    }

    //确定魔方的状态
    public string MofanStata(string mofanName)
    {
        n = int.Parse(mofanName.Substring(1)) - 1;
        int mofanNum = rType(GameManager.Instance.cubePrefabList[n].transform.rotation.ToString());
        mofanColor = mofanReColor(mofanName);
        switch (mofanColor.Length)
        {
            case 1:
                str = A(mofanColor, mofanNum);
                break;
            case 2:
                str = A(mofanColor[0].ToString(), mofanNum)+A(mofanColor[1].ToString(), mofanNum);
                break;
            case 3:
                str = A(mofanColor[0].ToString(), mofanNum) +A(mofanColor[1].ToString(), mofanNum)+ A(mofanColor[2].ToString(), mofanNum);
                break;

        }
        return str;
    }

    string A(string mofanColor,int mofanNum)
    {
        switch (mofanColor)
        {
            case "绿":
            case "蓝":
                switch (mofanNum)
                {
                    //F或B
                    case 0:
                    case 4:
                    case 5:
                    case 6:
                        if (mofanColor == "绿")
                            return "F" + mofanColor;
                        return "B" + mofanColor;
                    case 2:
                    case 12:
                    case 16:
                    case 18:
                        if (mofanColor == "绿")
                            return "B" + mofanColor;
                        return "F" + mofanColor;
                    //U或D
                    case 7:
                    case 9:
                    case 14:
                    case 20:
                        if (mofanColor == "绿")
                            return "U" + mofanColor;
                        return "D" + mofanColor;
                    case 8:
                    case 10:
                    case 17:
                    case 21:
                        if (mofanColor == "绿")
                            return "D" + mofanColor;
                        return "U" + mofanColor;
                    //L或R
                    case 1:
                    case 11:
                    case 15:
                    case 22:
                        if (mofanColor == "绿")
                            return "L" + mofanColor;
                        return "R" + mofanColor;
                    case 3:
                    case 13:
                    case 19:
                    case 23:
                        if (mofanColor == "绿")
                            return "R" + mofanColor;
                        return "L" + mofanColor;
                }
                break;
            case "红":
            case "橙":
                switch (mofanNum)
                {
                    //F或B
                    case 1:
                    case 9:
                    case 19:
                    case 21:
                        if (mofanColor == "红")
                            return "B" + mofanColor;
                        return "F" + mofanColor;
                    case 3:
                    case 10:
                    case 15:
                    case 20:
                        if (mofanColor == "红")
                            return "F" + mofanColor;
                        return "B" + mofanColor;
                    //U或D
                    case 4:
                    case 11:
                    case 16:
                    case 23:
                        if (mofanColor == "红")
                            return "D" + mofanColor;
                        return "U" + mofanColor;
                    case 6:
                    case 13:
                    case 18:
                    case 22:
                        if (mofanColor == "红")
                            return "U" + mofanColor;
                        return "D" + mofanColor;
                    //L或R
                    case 2:
                    case 5:
                    case 14:
                    case 17:
                        if (mofanColor == "红")
                            return "R" + mofanColor;
                        return "L" + mofanColor;
                    case 0:
                    case 7:
                    case 8:
                    case 12:
                        if (mofanColor == "红")
                            return "L" + mofanColor;
                        return "R" + mofanColor;
                }
                break;
            case "黄":
            case "白":
                switch (mofanNum)
                {
                    //F或B
                    case 8:
                    case 14:
                    case 22:
                    case 23:
                        if (mofanColor == "黄")
                            return "F" + mofanColor;
                        return "B" + mofanColor;
                    case 7:
                    case 11:
                    case 13:
                    case 17:
                        if (mofanColor == "黄")
                            return "B" + mofanColor;
                        return "F" + mofanColor;
                    //U或D
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        if (mofanColor == "黄")
                            return "U" + mofanColor;
                        return "D" + mofanColor;
                    case 5:
                    case 12:
                    case 15:
                    case 19:
                        if (mofanColor == "黄")
                            return "D" + mofanColor;
                        return "U" + mofanColor;
                    //L或R
                    case 4:
                    case 18:
                    case 20:
                    case 21:
                        if (mofanColor == "黄")
                            return "L" + mofanColor;
                        return "R" + mofanColor;
                    case 6:
                    case 9:
                    case 10:
                    case 16:
                        if (mofanColor == "黄")
                            return "R" + mofanColor;
                        return "L" + mofanColor;
                }
                break;
        }
        return "";
    }

    //魔方块编号转对应颜色
    public string mofanReColor(string mofanName)
    {
        switch (mofanName)
        {
            #region 中心块
            case "M11":
                return "绿"; 
            case "M17":
                return "蓝";
            case "M5":
                return "红";
            case "M23":
                return "橙";
            case "M13":
                return "白";
            case "M15":
                return "黄";
            #endregion
            #region 角块
            case "M21":
                return "黄绿橙";
            case "M27":
                return "黄橙蓝";
            case "M9":
                return "黄蓝红";
            case "M3":
                return "黄红绿";
            case "M7":
                return "白蓝红";
            case "M1":
                return "白红绿";
            case "M19":
                return "白绿橙";
            case "M25":
                return "白橙蓝";
            #endregion
            #region 棱块
            case "M6":
                return "黄红";
            case "M18":
                return "黄蓝";
            case "M24":
                return "黄橙";
            case "M12":
                return "黄绿";
            case "M4":
                return "白红";
            case "M10":
                return "白绿";
            case "M22":
                return "白橙";
            case "M16":
                return "白蓝";
            case "M8":
                return "蓝红";
            case "M20":
                return "绿橙";
            case "M2":
                return "红绿";
            case "M26":
                return "橙蓝";
                #endregion
        }
        return "";
    }

    //总24个状态角度,状态角度转成一个编号
    public int rType(string s)
    {
        switch (s)
        {
            #region 0-8
            case "(0.0, 0.0, 0.0)":
            case "(0.0, 0.0, 0.0, 1.0)":
            case "(0.0, 0.0, 0.0, -1.0)":
                return 0;
            case "(0.0, 90.0, 0.0)":
            case "(0.0, 0.7, 0.0, 0.7)":
            case "(0.0, -0.7, 0.0, -0.7)":
                return 1;
            case "(0.0, 180.0, 0.0)":
            case "(0.0, -1.0, 0.0, 0.0)":
            case "(0.0, 1.0, 0.0, 0.0)":
                return 2;
            case "(0.0, 270.0, 0.0)":
            case "(0.0, -0.7, 0.0, 0.7)":
            case "(0.0, 0.7, 0.0, -0.7)":
                return 3;
            case "(0.0, 0.0, 90.0)":
            case "(0.0, 0.0, -0.7, -0.7)":
            case "(0.0, 0.0, 0.7, 0.7)":
                return 4;
            case "(0.0, 0.0, 180.0)":
            case "(0.0, 0.0, 1.0, 0.0)":
            case "(0.0, 0.0, -1.0, 0.0)":
                return 5;
            case "(0.0, 0.0, 270.0)":
            case "(0.0, 0.0, 0.7, -0.7)":
            case "(0.0, 0.0, -0.7, 0.7)":
                return 6;
            case "(90.0, 0.0, 0.0)":
            case "(0.7, 0.0, 0.0, 0.7)":
            case "(-0.7, 0.0, 0.0, -0.7)":
                return 7;
            case "(270.0, 0.0, 0.0)":
            case "(-0.7, 0.0, 0.0, 0.7)":
            case "(0.7, 0.0, 0.0, -0.7)":
                return 8;
            #endregion
            #region 9-23
            case "(90.0, 90.0, 0.0)":
            case "(-0.5, -0.5, 0.5, -0.5)":
            case "(0.5, 0.5, -0.5, 0.5)":
                return 9;
            case "(270.0, 270.0, 0.0)":
            case "(-0.5, -0.5, -0.5, 0.5)":
            case "(0.5, 0.5, 0.5, -0.5)":
                return 10;
            case "(0.0, 90.0, 90.0)":
            case "(0.5, 0.5, 0.5, 0.5)":
            case "(-0.5, -0.5, -0.5, -0.5)":
                return 11;
            case "(0.0, 180.0, 180.0)":
            case "(1.0, 0.0, 0.0, 0.0)":
            case "(-1.0, 0.0, 0.0, 0.0)":
                return 12;
            case "(0.0, 270.0, 270.0)":
            case "(-0.5, 0.5, 0.5, -0.5)":
            case "(0.5, -0.5, -0.5, 0.5)":
                return 13;
            case "(90.0, 180.0, 0.0)":
            case "(0.0, -0.7, 0.7, 0.0)":
            case "(0.0, 0.7, -0.7, 0.0)":
                return 14;
            case "(0.0, 90.0, 180.0)":
            case "(-0.7, 0.0, -0.7, 0.0)":
            case "(0.7, 0.0, 0.7, 0.0)":
                return 15;
            case "(0.0, 180.0, 90.0)":
            case "(-0.7, -0.7, 0.0, 0.0)":
            case "(0.7, 0.7, 0.0, 0.0)":
                return 16;
            case "(270.0, 180.0, 0.0)":
            case "(0.0, -0.7, -0.7, 0.0)":
            case "(0.0, 0.7, 0.7, 0.0)":
                return 17;
            case "(0.0, 180.0, 270.0)":
            case "(0.7, -0.7, 0.0, 0.0)":
            case "(-0.7, 0.7, 0.0, 0.0)":
                return 18;
            case "(0.0, 270.0, 180.0)":
            case "(0.7, 0.0, -0.7, 0.0)":
            case "(-0.7, 0.0, 0.7, 0.0)":
                return 19;
            case "(90.0, 270.0, 0.0)":
            case "(-0.5, 0.5, -0.5, -0.5)":
            case "(0.5, -0.5, 0.5, 0.5)":
                return 20;
            case "(270.0, 90.0, 0.0)":
            case "(0.5, -0.5, -0.5, -0.5)":
            case "(-0.5, 0.5, 0.5, 0.5)":
                return 21;
            case "(0.0, 90.0, 270.0)":
            case "(-0.5, 0.5, -0.5, 0.5)":
            case "(0.5, -0.5, 0.5, -0.5)":
                return 22;
            case "(0.0, 270.0, 90.0)":
            case "(-0.5, -0.5, 0.5, 0.5)":
            case "(0.5, 0.5, -0.5, -0.5)":
                return 23;
            #endregion
            default:
                return -1;
        }
    }

    //总20个位置，位置转成可读字符编号
    string pType(string s)
    {
        switch (s)
        {
            #region 棱块
            //顶棱
            case "(0.0, 1.0, -1.0)":
                return "UF";
            case "(1.0, 1.0, 0.0)":
                return "UR";
            case "(0.0, 1.0, 1.0)":
                return "UB";
            case "(-1.0, 1.0, 0.0)":
                return "UL";
            //底棱
            case "(0.0, -1.0, -1.0)":
                return "DF";
            case "(1.0, -1.0, 0.0)":
                return "DR";
            case "(0.0, -1.0, 1.0)":
                return "DB";
            case "(-1.0, -1.0, 0.0)":
                return "DL";
            //前侧棱
            case "(1.0, 0.0, -1.0)":
                return "FR";
            case "(-1.0, 0.0, -1.0)":
                return "FL";
            //后侧棱
            case "(1.0, 0.0, 1.0)":
                return "BR";
            case "(-1.0, 0.0, 1.0)":
                return "BL";
            #endregion
            #region 角块
            //顶角块
            case "(1.0, 1.0, -1.0)":
                return "UFR";
            case "(-1.0, 1.0, -1.0)":
                return "ULF";
            case "(1.0, 1.0, 1.0)":
                return "URB";
            case "(-1.0, 1.0, 1.0)":
                return "UBL";

            //底角块
            case "(1.0, -1.0, -1.0)":
                return "DRF";
            case "(-1.0, -1.0, -1.0)":
                return "DFL";
            case "(1.0, -1.0, 1.0)":
                return "DBR";
            case "(-1.0, -1.0, 1.0)":
                return "DLB";
            #endregion
            default:
                return "";
        }
    }

    /// <summary>
    /// 按顺序读取魔方块
    /// </summary>
    /// <param name="content">无序的魔方块列表</param>
    /// <returns>返回有序的魔方块列表</returns>
    public string readMofanOrder(string content)
    {
        string[] strarr = content.Split(':');
        string[] restr = new string[strarr.Length];
        for (int i = 0; i < strarr.Length; i++)
        {
            n = int.Parse(strarr[i].Substring(1)) - 1;
            string mofanNum = pType(GameManager.Instance.cubePrefabList[n].transform.position.ToString());
            for (int j = 0; j < mofanPosArr.Length; j++)
            {
                if (mofanPosArr[j] == mofanNum)
                {
                    restr[j] = MofanStata(strarr[i]);
                }
            }
        }
        return string.Join(":",restr);
    }
    /// <summary>
    /// 按固定位置读取魔方块
    /// </summary>
    /// <param name="content">固定位置魔方块列表</param>
    /// <param name="isCross">是否拥有颜色</param>
    /// <returns>返回固定位置魔方块结果</returns>
    public string readMofanFixed(string content,bool isHaveColour)
    {
        string[] strarr = content.Split(':');
        string str = "";
        for (int i = 0; i < strarr.Length; i++)
        {
            if (isHaveColour)
            {
                str += MofanStata(strarr[i]) + ":";
                continue;
            }
            switch (MofanStata(strarr[i]).Length)
            {
                case 2:
                    str += MofanStata(strarr[i]).Remove(1) + ":";
                    break;
                case 4:
                    str += MofanStata(strarr[i]).Remove(1, 1).Remove(2)+":";
                    break;
                case 6:
                    str += MofanStata(strarr[i]).Remove(1, 1).Remove(2, 1).Remove(3) + ":";
                    break;
            }
        }

        return str.Substring(0, str.Length - 1);
    }
}

