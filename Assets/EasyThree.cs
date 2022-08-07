using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyThree
{
    private const float aspectFuteToKilogramme = 0.453f;
    
    public float GetKilogramme(float fute) => fute * aspectFuteToKilogramme;
    public float GetFute(float kilogramme) => kilogramme / aspectFuteToKilogramme;
    
}
