using System;
using System.Collections;
using System.Collections.Generic;
using DZ.QueueExample;
using UnityEngine;

public class QueueExample : MonoBehaviour
{
    
    void Start()
    {
        QueueEx<string> queueEx = new QueueEx<string>();
        
        queueEx.Enqueue("Привет");
        queueEx.Enqueue("Мой");
        queueEx.Enqueue("Друг");
        queueEx.Enqueue("!!!");
        
        Debug.Log(String.Join(", ", new List<string>(queueEx.ToArray())
            .ConvertAll(i => i.ToString())
            .ToArray()));
        
        Debug.Log(queueEx.Dequeue());
        
        Debug.Log(String.Join(", ", new List<string>(queueEx.ToArray())
            .ConvertAll(i => i.ToString())
            .ToArray()));
  

    }


}
