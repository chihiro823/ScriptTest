using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    int mp = 53;
    public void Magic()
    {
        if(mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Debug.Log("配列を順番に表示");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        Debug.Log("配列を逆順に表示");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[array.Length - i - 1]);
        }

        
        Debug.Log("Bossクラスを11回実行");
        Boss lastboss = new Boss();
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
