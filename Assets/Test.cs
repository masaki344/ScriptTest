using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start ()
    {
        int[] array = { 2, 4, 3, 1, 5 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }
	
	void Update ()
    {
		
	}
}
