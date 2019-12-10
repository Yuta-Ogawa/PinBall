using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointText : MonoBehaviour {

    private GameObject pointText;
    private int point = 0;

    // Use this for initialization
    void Start () {
        this.pointText = GameObject.Find("PointText");
    }
	
	// Update is called once per frame
	void Update() {
        
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "SmallStarTag") {
            this.point += 10;
        } else if (other.gameObject.tag == "LargeStarTag") {
            this.point += 20;
        } else if (other.gameObject.tag == "SmallCloudTag") {
            this.point += 30;
        } else if (other.gameObject.tag == "LargeCloudTag") {
            this.point += 40;
        }
        this.pointText.GetComponent<Text>().text = this.point + " point";

    }
}
