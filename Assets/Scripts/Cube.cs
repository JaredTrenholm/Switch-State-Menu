using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void Awake()
    {
        this.gameObject.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.up * Time.deltaTime)*Time.timeScale, Space.World);
        if (Vector3.Distance(this.gameObject.transform.position, Vector3.zero) > 15f)
        {
            Destroy(this.gameObject);
        }
    }
}
