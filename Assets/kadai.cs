using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //配列を初期化する
        int[] array = { 1, 2, 3, 4, 5 };
    
        //配列を要素数の分だけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)

        {
            Debug.Log(array[i]);
        }
    
        for (int i = 4; i >= 0; i--)
    
            {
            Debug.Log(array[i]);
        }
    }
    //update is called once per frame
    private void Update()
   {
        
    }
}

