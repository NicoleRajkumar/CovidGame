using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCheck : MonoBehaviour
{
    private Girl marian;
    // Start is called before the first frame update
    void Start()
    {
        marian = gameObject.GetComponentInParent<Girl>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        marian.isJumping = false;
        marian.becauseidk = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (marian.becauseidk)
        {
            marian.isJumping = true;
        }
    }

}
