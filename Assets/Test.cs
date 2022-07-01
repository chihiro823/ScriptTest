using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    public int Magic(int mp)
    {
        if(mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            return mp;
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
            return mp;
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

        int mp = 53;
        Debug.Log("Bossクラスを11回実行");
        for (int i = 0; i < 11; i++)
        {
            Boss lastboss = new Boss();
            mp = lastboss.Magic(mp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
