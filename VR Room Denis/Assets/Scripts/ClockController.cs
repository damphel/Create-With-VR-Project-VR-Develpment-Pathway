using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class ClockController : MonoBehaviour
{
    [SerializeField] Transform secondsArrow;
    [SerializeField] Transform minuteArrow;
    [SerializeField] Transform hourArrow;

    [Range(-1,1)] [Tooltip("-1 to left, +1 to right, 0 no movement")] 
    [SerializeField] int direction;

    DateTime localDate;
    int lastSecond = 0;
    int lastMinute = 0;
    int lastHour = 0;

    private void Start()
    {
        localDate = DateTime.Now;

        lastSecond = localDate.Second;
        lastMinute = localDate.Minute;
        lastHour = localDate.Hour;

        secondsArrow.eulerAngles = new Vector3((lastSecond*6f * direction), 0f, 0f);
        minuteArrow.eulerAngles = new Vector3((lastMinute * 6f * direction), 0f, 0f);
        hourArrow.eulerAngles = new Vector3((lastHour * 30f * direction), 0f, 0f);

        secondsArrow.localPosition = new Vector3(0.025f, secondsArrow.localPosition.y, 0);
        minuteArrow.localPosition = new Vector3(0.025f, minuteArrow.localPosition.y, 0);
        hourArrow.localPosition = new Vector3(0.025f, hourArrow.localPosition.y, 0);
    }

    void Update()
    {
        if (DateTime.Now.Second > lastSecond)
        {
            lastSecond = DateTime.Now.Second;
            secondsArrow.Rotate(Vector3.right*6f * direction);

            if (DateTime.Now.Minute > lastMinute)
            {
                lastMinute = DateTime.Now.Minute;
                minuteArrow.Rotate(Vector3.right * 6f * direction);

                if (DateTime.Now.Hour > lastHour)
                {
                    lastHour = DateTime.Now.Hour;
                    hourArrow.Rotate(Vector3.right * 30f * direction);
                }
            }
        }


        if (DateTime.Now.Second == 0)
        {
            lastSecond = DateTime.Now.Second;
            secondsArrow.eulerAngles = Vector3.zero;
        }
    }
}
