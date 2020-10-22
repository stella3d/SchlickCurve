using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchlickCurveTest : MonoBehaviour
{
    [Header("Generalized Schlick Curve")]
    [Range(0.01f, 10f)]
    public float Slope = 1f;
    [Range(0.01f, 1f)]
    public float Threshold = 0.5f;

    [Header("Visualization")]
    [Range(1f, 10f)]
    public float TravelLength;

    public Transform LinearCursor;
    public Transform CurveCursor;

    Vector3 m_CursorStart;

    // Start is called before the first frame update
    void Start()
    {
        m_CursorStart = LinearCursor.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // remap -1, 1 range of sin to 0,1
        var sin = (Mathf.Sin(Time.time) + 1f) * 0.5f;
        LinearCursor.localPosition = m_CursorStart + Vector3.right * (sin * TravelLength);

        var curveSin = Schlick.Curve(sin, Slope, Threshold);
        CurveCursor.localPosition = m_CursorStart + Vector3.right * (curveSin * TravelLength);
    }
}
