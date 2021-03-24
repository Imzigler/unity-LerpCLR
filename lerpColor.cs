using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpColor : MonoBehaviour
{
    MeshRenderer mesh;
    [SerializeField] Color[] mycolor;
    [SerializeField] [Range(0f, 1f)] float lerptime;
    float T;
    int ln;
    int colorinderx = 0;


    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        ln = mycolor.Length;
    }

    void Update()
    {
        mesh.material.color = Color.Lerp(mesh.material.color, mycolor[colorinderx], lerptime * Time.deltaTime);
        T = Mathf.Lerp(T, 1f, lerptime * Time.deltaTime);
        if (T > 0.9f)
        {
            T = 0f;
            colorinderx++;
            colorinderx = (colorinderx >= ln) ? 0 : colorinderx;
        }

    }
}
