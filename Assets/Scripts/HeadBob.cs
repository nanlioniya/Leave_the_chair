using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBob : MonoBehaviour
{
    public bool enable = true;
    public float xUpDown = 0.01f;
    public float yUp = 0.02f;
    public float yDown = 0.02f;
    public float frequency = 3f;


    private void Update()
    {
        if (enable)
        {
            Vector3 pos = Vector3.zero;
            pos += FootStepMotion();
            transform.localPosition += pos;
        }
    }

    private Vector3 FootStepMotion()
    {
        Vector3 pos = Vector3.zero;

        // effect 1
        //if (Mathf.Sin(Time.time * frequency) > 0)
        //{
        //    pos.y += Mathf.Sin(Time.time * frequency * yDown / (yUp + yDown)) * yUp;
        //}
        //else
        //{
        //    pos.y += Mathf.Sin(Time.time * frequency * yDown / (yUp + yDown)) * yDown;
        //}
        //pos.x += Mathf.Cos(Time.time * frequency / 2) * xUpDown;

        // effect 2
        pos.y += Mathf.Sin(Time.time * frequency) * yUp;
        pos.x += Mathf.Cos(Time.time * frequency / 2) * xUpDown;

        return pos;
    }
}
