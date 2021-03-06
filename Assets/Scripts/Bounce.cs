﻿using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour
{
    public Material darkMaterial;
    public Material lightMaterial;
    public float duration = 2.0f;

    public Renderer rend;

    // Use this for initialization
    void Start ()
    {
        rend = GetComponent<Renderer>();
        rend.material = darkMaterial;
    }
	
	// Update is called once per frame
	void Update ()
	{
	    float sinDelta = Mathf.Sin(Time.time);
        float lerp = Mathf.PingPong(Time.time, duration) / duration;

        transform.position = new Vector3(0, sinDelta + 2,0);
        rend.material.Lerp(darkMaterial, lightMaterial, lerp);
	}
}
