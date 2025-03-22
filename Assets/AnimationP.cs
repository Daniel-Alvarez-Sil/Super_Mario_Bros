using UnityEngine;

public class AnimationP : MonoBehaviour
{
    public Material material; // The material using the custom shader
    public float speed = 1f;

    void Update()
    {
        float t = (Mathf.Sin(Time.time * speed) + 1f) / 2f; // goes from 0 to 1
        material.SetFloat("_Saturation", t); // Assuming the shader has a "_Saturation" property
    }
}