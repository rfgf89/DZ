using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyFour : MonoBehaviour
{
    public void PrintMinMaxValue(float one, float two)
    {
        Debug.Log($"Max Value {Mathf.Max(one, two)}");
        Debug.Log($"Min Value {Mathf.Min(one, two)}");
    }
    
        
    
}
