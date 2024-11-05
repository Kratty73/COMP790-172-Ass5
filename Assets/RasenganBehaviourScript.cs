using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RasenganBehaviourScript : MonoBehaviour
{
    // 100, 188, 255, 63 - 12, 48, 96
    // 57, 169, 248, 0
    // 191, 250, 255, 255


    public bool active = false;
    public float speed = 0.005f;
    public int colour = 0;
    public float min_size = 0.0f;
    public float max_size = 2.0f;
    private float interpolate = 0.0f;
    private float size = 0.5f;
    private float initial_size = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        active = true;
        initial_size = transform.localScale.x;
        size = max_size;
        interpolate = max_size * speed;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            size += interpolate;
        }
        if (Input.GetKey(KeyCode.X))
        {
            size -= interpolate;
        }
        size = Mathf.Clamp(size,
                    min_size,
                    max_size);
        transform.localScale = new Vector3(size,
                          size,
                          size);
        active = size > 0;
    }
}
