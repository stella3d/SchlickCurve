using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public static class GeneralizedSchlick
{
    public static float Bias(float x, float a)
    {
        return x / ((1f / a - 2f) * (1f - x) + 1f);
    }
    
    public static double Bias(double x, double a)
    {
        return x / ((1f / a - 2f) * (1f - x) + 1f);
    }
}
