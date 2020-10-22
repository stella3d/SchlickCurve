using System;

public static class Schlick
{
    const string CantBeNegativeError = "cannot be less than 0";
    const string RangeError = "must be within 0..1";
    
    /// <summary>
    /// A generalization of Schlick's 'bias' and 'gain' functions, useful for producing easing effects
    /// </summary>
    /// <param name="x">input value, from 0 to 1</param>
    /// <param name="slope">slope of the curve starting at the <paramref name="threshold"/></param>
    /// <param name="threshold">value of <paramref name="x"/> where the curve reverses its shape</param>
    /// <returns></returns>
    public static float Curve(float x, float slope, float threshold)
    {
#if UNITY_EDITOR && !DISABLE_SCHLICK_CURVE_CHECKS
        if(slope < 0)
            throw new ArgumentOutOfRangeException(nameof(slope), CantBeNegativeError);
        if(!(threshold >= 0 && threshold <= 1))
            throw new ArgumentOutOfRangeException(nameof(threshold), RangeError);
        if(!(x >= 0 && x <= 1))
            throw new ArgumentOutOfRangeException(nameof(x), RangeError);
#endif
        
        return x < threshold 
            ? (threshold * x) / (x + slope * (threshold - x) + float.Epsilon) 
            : (1f - threshold) * (x - 1f) / (1f - x - slope * (threshold - x) + float.Epsilon) + 1f;
    }
    
    /// <summary>
    /// A generalization of Schlick's 'bias' and 'gain' functions, useful for producing easing effects
    /// </summary>
    /// <param name="x">input value, from 0 to 1</param>
    /// <param name="slope">slope of the curve starting at the <paramref name="threshold"/></param>
    /// <param name="threshold">value of <paramref name="x"/> where the curve reverses its shape</param>
    public static double Curve(double x, double slope, double threshold)
    {
#if UNITY_EDITOR && !DISABLE_SCHLICK_CURVE_CHECKS
        if(slope < 0)
            throw new ArgumentOutOfRangeException(nameof(slope), CantBeNegativeError);
        if(!(threshold >= 0 && threshold <= 1))
            throw new ArgumentOutOfRangeException(nameof(threshold), RangeError);
        if(!(x >= 0 && x <= 1))
            throw new ArgumentOutOfRangeException(nameof(x), RangeError);
#endif
        
        return x < threshold 
            ? (threshold * x) / (x + slope * (threshold - x) + double.Epsilon) 
            : (1d - threshold) * (x - 1d) / (1d - x - slope * (threshold - x) + double.Epsilon) + 1d;
    }
}
