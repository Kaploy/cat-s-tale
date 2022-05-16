using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaintainAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()

    {

        int numOfSessions = FindObjectsOfType<MaintainAudio>().Length;

        if (numOfSessions > 1)

        {

            Destroy(gameObject);

        }

        else

        {

            DontDestroyOnLoad(gameObject);

        }
    }
    }
