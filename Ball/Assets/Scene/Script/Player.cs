using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private int i = 0;
	
	// Update is called once per frame
	void Update () {
        float horizontal_move = Input.GetAxis("Horizontal");
        float vertical_move = Input.GetAxis("Vertical");
        //旧版本写法
        //this.rigibody.AddForce(new Vector3(horizontal_move,0,vertical_move));
        //新版本写法
        GetComponent<Rigidbody>().AddForce(new Vector3(horizontal_move,0,vertical_move));

    }
    //判断小球的食物
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "food") {
            //销毁食物
            GameObject.Destroy(other.gameObject);
            i++;
            if (i==6) {
                Debug.Log("You win");  
            }

        }

     }
    /*
    void OnTriggerExit() {
        Debug.Log("I am Exit");
    }
    void OnTriggerStay()
    {
        Debug.Log("I am Stay");
    }
    */
}
