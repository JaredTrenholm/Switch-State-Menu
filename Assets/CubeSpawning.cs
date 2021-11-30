using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawning : MonoBehaviour
{
    void Update()
    {
        for (int i = 0; i <= Time.timeScale && GameManager.gameManager.IsInGame(); i++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.AddComponent<Cube>();
            Material newMat = new Material(cube.GetComponent<Renderer>().material);

            float random = Random.Range(0, 3);
            float r;
            float b;
            float g;
            if (random == 0)
            {
                r = Random.Range(0, 256);
                b = Random.Range(0, 256) - r;
                g = Random.Range(0, 256) - r - b;
            } else if(random == 1)
            {
                b = Random.Range(0, 256);
                g = Random.Range(0, 256) - b;
                r = Random.Range(0, 256) - g - b;
            } else
            {
                g = Random.Range(0, 256);
                r = Random.Range(0, 256) - g;
                b = Random.Range(0, 256) - r - g;
            }

            Color color = new Color(r, g, b, 255);
            newMat.color = color;
            cube.GetComponent<Renderer>().material = newMat;
        }

        
    }
}
