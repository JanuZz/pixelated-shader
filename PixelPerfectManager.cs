using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectManager : MonoBehaviour
{
    public Shader Shader;
    [Range((float) 0.01,1)]
    public double Resolution;
    Material PixelMat;

    private void Start()
    {
        PixelMat = new Material(Shader);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        PixelMat.SetFloat("_Resolution", (float) Resolution);
        Graphics.Blit(source, destination, PixelMat);
    }
}
