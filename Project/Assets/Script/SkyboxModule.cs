using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxModule : DN_ModelBase
{
    [SerializeField]
    private Gradient skycolor;
    [SerializeField]
    private Gradient horizonColor;
    public override void UpdateModule(float intensity)
    {
        RenderSettings.skybox.SetColor("_SkyTint", skycolor.Evaluate(intensity));
        RenderSettings.skybox.SetColor("_GroundColor", horizonColor.Evaluate(intensity));
    }
}
