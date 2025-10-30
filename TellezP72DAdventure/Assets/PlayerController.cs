using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 position = transform.position;
        position.x = position.x + 0.1f;
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
