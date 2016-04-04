using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelSection : MonoBehaviour
{
    public List<Enemy> Enemies;
    public int EnemiesLeft;

    private float blendTime;

	// Use this for initialization
	void Start()
	{
	    EnemiesLeft = Enemies.Count;
	    blendTime = 0.0f;
	}
	
	// Update is called once per frame
	void Update()
    {
	    if (EnemiesLeft <= 0)
	    {

	        
	    }


	}

    void TriggerBlend()
    {
        foreach (Enemy enemy in Enemies)
        {
            
        }
    }
}
