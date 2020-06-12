using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other){
    	RubyController controller = other.GetComponent<RubyController>();

	    if (controller != null)
	    {
	    	if (controller.health > 0) {
	    		controller.ChangeHealth(-1);
	    	}
	        
	    }
    }
}
