using UnityEngine;
using System;
using System.Globalization;

//获取序数order
public class GetOrder : MonoBehaviour
{
    public static int order = TimeForesee();

    private static int TimeForesee()
    {
        // 获取当前日期
        DateTime currentDate = DateTime.Now;
        int hour;
        // 创建一个ChineseLunisolarCalendar对象
        ChineseLunisolarCalendar chineseCalendar = new ChineseLunisolarCalendar();
        
        // 将当前日期转换为农历日期
        int month = chineseCalendar.GetMonth(currentDate);
        int day = chineseCalendar.GetDayOfMonth(currentDate);
        //换算古代时辰
        if (System.DateTime.Now.Hour>=23)
        {
            hour = 1;
        }
        else
            hour = System.DateTime.Now.Hour/2+2;
        

        return month + day + hour - 2;
    }
}