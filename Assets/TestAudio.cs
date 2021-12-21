using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAudio : MonoBehaviour
{

    public static TestAudio Instance;

    void Awake()
    {




        DontDestroyOnLoad(this);
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance.gameObject);
        }

    }
}
