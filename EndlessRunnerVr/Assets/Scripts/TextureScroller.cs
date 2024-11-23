using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    [SerializeField] Renderer renderer;
    [SerializeField] Material material;
    [SerializeField] Vector2 textureScrollSpeed;

    // Start is called before the first frame update
    void Start()
    {
        material = renderer.sharedMaterial;
        renderer.sharedMaterial = material;
    }

    // Update is called once per frame
    void Update()
    {
        material.mainTextureOffset += textureScrollSpeed * Time.deltaTime;
        if(material.mainTextureOffset.x <-1 || material.mainTextureOffset.x>1)
        {
            material.mainTextureOffset = new Vector2(0,material.mainTextureOffset.y);
        }
        if (material.mainTextureOffset.y < -1 || material.mainTextureOffset.y > 1)
        {
            material.mainTextureOffset = new Vector2(material.mainTextureOffset.x,0);
        }
    }
}
