using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyThree
{
    private const float aspectPoundToKilogramme = 0.453f;
    
    public float GetKilogramme(float fute) => fute * aspectPoundToKilogramme;
    public float GetPound(float kilogramme) => kilogramme / aspectPoundToKilogramme;
    
}
