using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LaunchScene : MonoBehaviour
{
	private SteamVR_TrackedContoller controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.getComponent<SteamVR_TrackedController>();
    }	

    // Update is called once per frame
    void Update()
    {
    		if (controller.triggerPressed)
		{
			RayCast	hit;
			
			if (Physics.Raycast(new Ray(gameObject.transform.position, gameObject.transform.forward), out hit))
            {
                if (hit.collider.name.Equals("startButton"))
                {
                    hit.collider.gameObject.GetComponent<MenuStartButton>().LoadGameScene();
                }
            }
		}   
    }
}
