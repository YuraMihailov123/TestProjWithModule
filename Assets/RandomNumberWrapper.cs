using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RandomNumber;

public static class RandomNumberWrapper
{

    public static void Init()
    {
        if (!PlayerPrefs.HasKey("init"))
        {
            PlayerPrefs.SetInt("init", MyClass.GetRandomNumber());
        }
        DoActions(PlayerPrefs.GetInt("init"));
    }

    static void DoActions(int num)
    {
        switch (num)
        {
            case 0:
                Debug.Log(Application.productName);
                break;
            case 1:
                Application.OpenURL("https://yandex.ru");
                break;
        }
    }
}
