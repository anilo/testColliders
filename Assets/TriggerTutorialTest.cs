using UnityEngine;
using System.Collections;

public class TriggerTutorialTest : MonoBehaviour {

	void OnTriggerEnter(Collider collisionInfo)
	{
		print("Detected trigger between " + gameObject.name + " and " + collisionInfo.GetComponent<Collider>().name);
	}
	
	void OnTriggerStay(Collider collisionInfo)
	{
		print(gameObject.name + " and " + collisionInfo.GetComponent<Collider>().name + " are still colliding");
	}
	
	void OnTriggerExit(Collider collisionInfo)
	{
		print(gameObject.name + " and " + collisionInfo.GetComponent<Collider>().name + " are no longer colliding");
	}

}
