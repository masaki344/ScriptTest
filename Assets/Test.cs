using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    void Start ()
    {
        for(int zyun = 0; zyun <= 1; zyun++)
        {
            int[] array = { 2, 4, 3, 1, 5 };
            int[] hako = new int[5];
            for (int a = 0; a < array.Length; a++)
            {
                int n = 0;
                for (int b = 0; b < array.Length; b++)
                {
                    if (zyun == 0)
                    {
                        if (array[a] > array[b])
                        {
                            n++;
                        }
                    }
                    else if (zyun == 1)
                    {
                        if (array[a] < array[b])
                        {
                            n++;
                        }
                    }
                }
                hako[n] = array[a];
            }
            for (int c = 0; c < array.Length; c++)
            {
                Debug.Log(hako[c]);
            }
        } 
    }
	
	void Update ()
    {
		
	}
}
