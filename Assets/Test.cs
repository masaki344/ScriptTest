using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //配列を宣言して出力しましょう
    void Start ()
    {
        int[] array = { 2, 4, 3, 1, 5 };
        //昇順を出力する
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        //降順を出力する
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }
	
	void Update ()
    {
		
	}
}
