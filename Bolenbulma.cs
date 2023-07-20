using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolenbulma : MonoBehaviour
{
    public void BolenFonk(int num1, int num2)
    {
        int start = Mathf.Min(num1, num2);
        int end = Mathf.Max(num1, num2);

        List<int> divideByTwo = new List<int>();
        List<int> divideByThree = new List<int>();
        List<int> divideByFour = new List<int>();
        List<int> divideByFive = new List<int>();
        List<int> allNumbers = new List<int>();

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                divideByTwo.Add(i);
            }

            if (i % 3 == 0)
            {
                divideByThree.Add(i);
            }

            if (i % 4 == 0)
            {
                divideByFour.Add(i);
            }

            if (i % 5 == 0)
            {
                divideByFive.Add(i);
            }
            allNumbers.Add(i);
        }

        Debug.Log("Tüm sayılar: " + ListeYazdır(allNumbers));
        Debug.Log("2'ye bölünenler: " + ListeYazdır(divideByTwo));
        Debug.Log("3'e bölünenler: " + ListeYazdır(divideByThree));
        Debug.Log("4'e bölünenler: " + ListeYazdır(divideByFour));
        Debug.Log("5'e bölünenler: " + ListeYazdır(divideByFive));

       
    }
    private string ListeYazdır(List<int> a)
    {
        string temp = "";
        for (int i = 0; i < a.Count; i++)
        {
            temp += " - ";
            temp += a[i];
        }

        return temp;
    }

   

    private void Start()
    {

        BolenFonk(15, 35);

    }


}


