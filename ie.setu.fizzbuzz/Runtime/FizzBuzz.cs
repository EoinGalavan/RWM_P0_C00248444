using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    public static int[] fizz(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = fizz(xs[i]);
        }
        return result;
    }

    public static int fizz(int num)
    {
        if(num%3 == 0)
        {
            if(num%5 == 0)
            {
                num = 0;
            }
            else
            {
                num = 3;
            }
        }
        else if(num%5 == 0)
        {
            num = 5;
        }
        return num;
    }
}
