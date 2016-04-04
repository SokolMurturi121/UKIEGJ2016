using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelSection : MonoBehaviour
{
    public IList<IEnemy> Enemies;
    public int EnemiesLeft;

	// Use this for initialization
	void Start()
	{
	    EnemiesLeft = Enemies.Count;
	}
	
	// Update is called once per frame
	void Update()
    {
	    if(EnemiesLeft <=0)
            TriggerBlend();
	}

    void TriggerBlend()
    {
        
    }
}
