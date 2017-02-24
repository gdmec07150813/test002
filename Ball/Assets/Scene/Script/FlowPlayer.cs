using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowPlayer : MonoBehaviour {

    public GameObject player;
	
	// Update is called once per frame
	void Update () {
       Vector3 player_position = player.GetComponent<Transform>().position;
  this.GetComponent<Transform>().position = new Vector3(player_position.x,player_position.y+6.42f,player_position.z-4.78f);
        
    }
}
