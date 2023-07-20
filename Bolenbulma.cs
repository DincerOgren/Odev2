using System.Collections.Generic;
using UnityEngine;

public class Bolenbulma : MonoBehaviour
{
    public void BolenFonk(int num1, int num2)
    {
        int start = Mathf.Min(num1, num2);
        int end = Mathf.Max(num1, num2);

        List<int> divdeBytwo = new List<int>();
        List<int> divideBythree = new List<int>();
        List<int> divideByfive = new List<int>();

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                divdeBytwo.Add(i);
            }

            if (i % 3 == 0)
            {
                divideBythree.Add(i);
            }

            if (i % 5 == 0)
            {
                divideByfive.Add(i);
            }
        }

        Debug.Log("2'ye bölünenler: " + string.Join("-", divdeBytwo));
        Debug.Log("3'e bölünenler: " + string.Join("-", divideBythree));
        Debug.Log("5'e bölünenler: " + string.Join("-", divideByfive));
    }

    private void Start() {
        
        BolenFonk(10,35);
        
    }


}


