using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CustomInput
{
    private static float xAxis;
    private static float yAxis;
    private static bool jump;
    public static float GetHorizontalAxis()
    {
        return xAxis;
    }
    public static float GetVerticalAxis()
    {
        return yAxis;
    }
    public static bool IsJump()
    {
        return jump;
    }
    public static void SetJump(bool status)
    {
        jump = status;
    }
    public static void SetHorizontalAxis(float value)
    {
        xAxis = value;
    }
    public static void SetVerticalAxis(float value)
    {
        yAxis = value;
    }
}
