﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    public List<GameObject> Effect;
    [SerializeField]
    private GameObject TouchEffects; //set toucheffect at unity engine
    private Transform Position;
    // Use this for initialization
    private void Awake()
    {
    }
    void Start()
    {
        Effect = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            //Vector3 ScreenPosition =Input.mousePosition;
            Vector3 ScreenPosition = Input.GetTouch(0).position;// 으로 해야함

            Vector3 StartPosition = Camera.main.ScreenToWorldPoint(new Vector3(ScreenPosition.x, ScreenPosition.y
                , Camera.main.nearClipPlane));
            Vector3 EndPosition = Camera.main.ScreenToWorldPoint(new Vector3(ScreenPosition.x, ScreenPosition.y
                , Camera.main.farClipPlane));
            Ray r = new Ray(StartPosition, EndPosition - StartPosition);
            RaycastHit result;
            if (Physics.Raycast(r, out result))
            {
                if (this.gameObject == result.transform.gameObject)
                {
                    Debug.Log(result.point);
                    TouchEffect().transform.position = result.point;

                }
            }
        }
    }
    public GameObject TouchEffect()
    {
        Debug.Log("here");
        for (int i = 0; i < Effect.Count; i++)
        {
            if (Effect[i].gameObject.activeInHierarchy == false)
            {
                Effect[i].gameObject.SetActive(true);
                return Effect[i];
            }
        }
        GameObject newEffect = Instantiate(TouchEffects);
        Effect.Add(newEffect);
        return newEffect;
    }
}
