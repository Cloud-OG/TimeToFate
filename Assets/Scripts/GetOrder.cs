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
        
        // 创建一个ChineseLunisolarCalendar对象
        ChineseLunisolarCalendar chineseCalendar = new ChineseLunisolarCalendar();
        
        // 将当前日期转换为农历日期
        int month = chineseCalendar.GetMonth(currentDate);
        int day = chineseCalendar.GetDayOfMonth(currentDate);
        
        // 获取当前小时
        int currentHour = currentDate.Hour;
        
        // 根据当前小时计算古代时辰
        int hour;
        if (currentHour >= 23 || currentHour < 1)
        {
            hour = 1; // 子时
        }
        else
        {
            hour = (currentHour + 1) / 2 + 1;
        }
    
        return month + day + hour - 2;
    }
}
