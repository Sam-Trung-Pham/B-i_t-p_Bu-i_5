using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spon : MonoBehaviour
{
    public GameObject hinhVuong;
    // Start is called before the first frame update
    private float countdown;
    public float timeDuration;

    private void Awake()
    {
        countdown = timeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;// mỗi frame countdown -=1/fps
        if (countdown<=0)
        {
           // Debug.Log("Sinh ra 1 hình vuông");
           Instantiate(hinhVuong, new Vector3(Random.Range(-6f,6f), 3 ,0),Quaternion.identity);
            countdown = timeDuration;
        }
    }
    
}
