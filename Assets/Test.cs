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
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
            return mp;
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
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

        Debug.Log("�z������Ԃɕ\��");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        Debug.Log("�z����t���ɕ\��");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[array.Length - i - 1]);
        }

        int mp = 53;
        Debug.Log("Boss�N���X��11����s");
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
