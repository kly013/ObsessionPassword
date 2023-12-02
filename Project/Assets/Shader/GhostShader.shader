Shader "Unlit/NewUnlitShader"
{
    Properties
    {
        _RimColor("RimColor",Color)=(0,0,1,1)
        _RimIntensity("Intensity",Range(0,2))=1
    }
    SubShader
    {
        Tags { "Queue"="Transparent""RenderType"="Opaque"}
        LOD 200

        Pass
        {
            Blend SrcAlpha One
            ZWrite off
            Lighting off

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float3 normal : Normal;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                fixed4 color : COLOR;
            };

            fixed4 _RimColor;
            float  _RimIntensity;

            v2f vert (appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                float3 viewDir = normalize(ObjSpaceViewDir(v.vertex));
                float val = 1 - saturate(dot(v.normal, viewDir));
                o.color = _RimColor * val * (1 + _RimIntensity);
                
                return o;
            }

            fixed4 frag(v2f i) : COLOR
            {
                return i.color;
            }
            ENDCG
        }
    }
}
