using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSoundScript : MonoBehaviour
{
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        this.source = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (tag == "BlockTag"|| tag == "GroundTag")
        {
            this.source.Play();
        }
    }
}
