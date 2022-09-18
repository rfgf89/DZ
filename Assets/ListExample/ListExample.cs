using System;
using System.Collections.Generic;
using DZ.ListExample;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    
    void Start()
    {
        ListEx<string> listEx = new ListEx<string>();
        listEx.Add("Привет");
        listEx.Add("Мой");
        listEx.Add("Друг");
        
     
        Debug.Log(String.Join(", ", new List<string>(listEx.ToArray())
                .ConvertAll(i => i.ToString())
                .ToArray()));
        
        listEx.Remove("Мой");
        
        Debug.Log(String.Join(", ", new List<string>(listEx.ToArray())
                .ConvertAll(i => i.ToString())
                .ToArray()));
    }
    
}