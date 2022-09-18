using UnityEngine;


public class EasyOne
{
    public float GetTrianglePerimeter(float catOne, float catTwo) =>
        Mathf.Sqrt(catOne * catOne + catTwo * catTwo) + catOne + catTwo;
    
}
