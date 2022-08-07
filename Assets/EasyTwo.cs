using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum DayWeek : byte
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
public class EasyTwo : MonoBehaviour
{
    public void Start()
    {
       //for (int i = 1; i < 8; i++)
         //   Debug.Log(GetDayWeek(i));
    }

    public DayWeek GetDayWeek(int day)
    {
        
        switch (day)
        {
            case 1 : return DayWeek.Monday;
            case 2 : return DayWeek.Tuesday;
            case 3 : return DayWeek.Wednesday;
            case 4 : return DayWeek.Thursday;
            case 5 : return DayWeek.Friday;
            case 6 : return DayWeek.Saturday;
            case 7 : return DayWeek.Sunday;
            default : throw new Exception($"DayWeek missing day : {day}");
        }
    }
}
