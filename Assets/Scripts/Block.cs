using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "GameObject" && other.gameObject.transform.childCount - 1 > 1)
            {
            this.GetComponent<BoxCollider>().enabled = false; // carpilan block'un collider'ı kapat bug önlemek icin
            other.GetContact(0).otherCollider.gameObject.transform.parent = null;
        }
        else 
        {
            FailHandler.Instance.HandleFail();
        } 
    }
   
}
