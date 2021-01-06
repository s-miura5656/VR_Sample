using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class OculusQuestSetting : MonoBehaviour
{
    [Header("画面の解像度")]
    [SerializeField] private float textureResolution = 1.0f;

    private void Awake()
    {
        XRSettings.eyeTextureResolutionScale = textureResolution;
    }
}
