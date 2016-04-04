using System;
using UnityEngine;
using System.Collections;

public class BlendableItem : MonoBehaviour
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
	    float lerp = Time.deltaTime/duration;
        rend.material.Lerp(darkMaterial, lightMaterial, lerp);
    }
}
