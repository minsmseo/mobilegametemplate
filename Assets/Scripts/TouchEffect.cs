using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchEffect : MonoBehaviour
{
    private float Timer;
    [SerializeField]
    private float HowLong;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Timer = HowLong;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer <= 0)
        {
            gameObject.SetActive(false);
        }
        else
        {
            Timer -= Time.deltaTime;
        }
    }
}
