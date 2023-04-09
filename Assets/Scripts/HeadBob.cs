using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBob : MonoBehaviour
{
    public bool enable = true;
    public float xAmplitude = 0.015f;
    public float yAmplitude = 0.015f;
    public float frequency = 10f;


    private void Update()
    {
        if (enable)
        {
            Vector3 pos = Vector3.zero;
            pos += FootStepMotion();
            transform.position += pos;
        }
    }

    private Vector3 FootStepMotion()
    {
        Vector3 pos = Vector3.zero;
        pos.y += Mathf.Sin(Time.time * frequency) * yAmplitude;
        pos.x += Mathf.Cos(Time.time * frequency / 2) * xAmplitude;
        return pos;
    }
}
