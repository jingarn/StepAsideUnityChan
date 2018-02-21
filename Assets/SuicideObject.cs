using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 見えてない→見えた→見えなくなった を経ると自壊するオブジェクトにする
/// </summary>
public class SuicideObject : MonoBehaviour
{
    private bool isVisible;
    private Renderer renderer;

    // Use this for initialization
    void Start()
    {
        if (this.tag == "CoinTag")
        {
            renderer = this.transform.Find("Cylinder").GetComponent<Renderer>();
        }
        else
        {
            renderer = GetComponent<Renderer>();
        }

        isVisible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isVisible)
        {
            if (renderer.isVisible)
            {
                isVisible = true;
            }
        }
        else
        {
            if (!renderer.isVisible)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
