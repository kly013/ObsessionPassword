Shader "Custom/WaterShader"
{
    Properties
    {
        // 基礎色
        _Color("Color", Color) = (1,1,1,1)

        _Glossiness("Smoothness", Range(0,1)) = 0.5
        _Metallic("Metallic", Range(0,1)) = 0.0

        // 淺水區顏色
        _WaterShallowColr("WaterShallowColr", Color) = (1,1,1,1)
        // 深水區顏色
        _WaterDeepColr("WaterDeepColr", Color) = (1,1,1,1) 

        // 透明度
        _TranAmount("TranAmount",Range(0,100)) = 0.5
        // 深度
        _DepthRange("DepthRange",Range(0.1,100)) = 1

        // normalmap
        _NormalTex("Normal",2D) = "bump"{}

        // 流速
        _WaterSpeed("WaterSpeed" ,float) = 1

        // 法線貼圖密集度
        _Refract("Refract",float) = 0.1

    }
    SubShader
    {
        Tags { "RenderType" = "Transparent" "Queue" = "Transparent"}
        LOD 200

        Zwrite off

        CGPROGRAM
        // #pragma surface surf Standard fullforwardshadows

        // Standard 光照模型
        // vertex:vert 著色器函數
        // noshadow 無陰影 surface sader會自動處理
        #pragma surface surf Standard vertex:vert alpha noshadow

        #pragma target 3.0

        sampler2D _MainTex;

        sampler2D_float _CameraDepthTexture;

        struct Input
        {
            float2 uv_MainTex;
            float4 proj;
            float2 uv_NormalTex;
        };

        half _Glossiness;
        half _Metallic;
        fixed4 _Color;
        fixed4 _WaterDeepColr;
        fixed4 _WaterShallowColr;
        half _TranAmount;
        half _DepthRange;
        half _WaterSpeed;
        sampler2D _NormalTex;
        half _Refract;

        UNITY_INSTANCING_BUFFER_START(Props)

        UNITY_INSTANCING_BUFFER_END(Props)

            
        void vert(inout appdata_full v, out Input i)
        {
            UNITY_INITIALIZE_OUTPUT(Input, i);
            i.proj = ComputeGrabScreenPos(UnityObjectToClipPos(v.vertex));
            COMPUTE_EYEDEPTH(i.proj.z);
        }

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            half depth = LinearEyeDepth(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(IN.proj)).r);
            half deltaDepth = depth - IN.proj.z;

            // 根據深度獲取顏色值
            fixed4 c = lerp(_WaterShallowColr, _WaterDeepColr, min(_DepthRange, deltaDepth) / _DepthRange);

            float4 bumpColor1 = tex2D(_NormalTex, IN.uv_NormalTex + float2(_WaterSpeed * _Time.x, 0));
            float2 offset = UnpackNormal(bumpColor1).xy * _Refract;
            bumpColor1 = tex2D(_NormalTex, IN.uv_NormalTex + offset + float2(_WaterSpeed * _Time.x, 0));
            float3 normal = UnpackNormal(bumpColor1).xyz;

            o.Normal = normal;

            o.Albedo = c.rgb;
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;

            o.Alpha = c.a * _TranAmount;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
