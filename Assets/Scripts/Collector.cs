using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Collect")
        {
            other.gameObject.transform.position = new Vector3(this.transform.position.x, other.gameObject.transform.position.y, this.transform.position.z);

            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.052f, this.transform.position.z);

            other.gameObject.transform.parent = this.transform;
            other.gameObject.tag = "Collector";

            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            GameObject.Find("CubeYellowCollector").GetComponent<BoxCollider>().isTrigger = false;
        }
    }

   

}
