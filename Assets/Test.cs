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
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
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

        
        Debug.Log("Boss�N���X��11����s");
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
