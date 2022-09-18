using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DZ.StackExample;
using UnityEngine;

public class StackExample : MonoBehaviour
{
    
    public void Start()
    {
        StackEx<string> st = new StackEx<string>();
        st.Push("Привет");
        st.Push("Мой");
        st.Push("Друг");
        
        Debug.Log(st.Contains("Друг"));
        Debug.Log(st.Pop() + " Count : " + st.Count);
        Debug.Log(st.Contains("Мой"));
        
        Debug.Log(st.Peek());
        Debug.Log(st.Peek());
        Debug.Log(st.Peek());
        
        Debug.Log(st.Pop() + " Count : " + st.Count);
        Debug.Log(st.Contains("Привет"));
        Debug.Log(st.Pop() + " Count : " + st.Count);
        
        
        Debug.Log(st.Contains("Привет"));
        Debug.Log(st.Contains("Мой"));
        Debug.Log(st.Contains("Друг"));
    }
}