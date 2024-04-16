Shader "Custom/DualMaterialShader" {
    Properties{
        // 正面
        _FrontColor("Front Main Color", Color) = (1,1,1,1)
        _FrontSpecColor("Front Specular Color", Color) = (0.5, 0.5, 0.5, 1)
        _FrontShininess("Front Shininess", Range(0.03, 1)) = 0.078125
        _FrontMainTex("Front Base (RGB) Gloss (A)", 2D) = "white" {}
        _FrontBumpMap("Front Normalmap", 2D) = "bump" {}

        // 反面
        _BackColor("Back Main Color", Color) = (1,1,1,1)
        _BackSpecColor("Back Specular Color", Color) = (0.5, 0.5, 0.5, 1)
        _BackShininess("Back Shininess", Range(0.03, 1)) = 0.078125
        _BackMainTex("Back Base (RGB) Gloss (A)", 2D) = "white" {}
        _BackBumpMap("Back Normalmap", 2D) = "bump" {}

        // 控制翻頁
        _Flip("Flip", Range(0, 1)) = 0
    }

        SubShader{
            Tags { "RenderType" = "Opaque" }
            LOD 400

            Cull Back

            CGPROGRAM
            #pragma surface surf BlinnPhong

            sampler2D _FrontMainTex;
            sampler2D _FrontBumpMap;
            fixed4 _FrontColor;
            half _FrontShininess;

            sampler2D _BackMainTex;
            sampler2D _BackBumpMap;
            fixed4 _BackColor;
            half _BackShininess;

            fixed _Flip;

            struct Input {
                float2 uv_FrontMainTex;
                float2 uv_FrontBumpMap;
                float2 uv_BackMainTex;
                float2 uv_BackBumpMap;
            };

            void surf(Input IN, inout SurfaceOutput o) {
                if (_Flip < 0.5) {
                    // 正面
                    fixed4 tex = tex2D(_FrontMainTex, IN.uv_FrontMainTex);
                    o.Albedo = tex.rgb * _FrontColor.rgb;
                    o.Gloss = tex.a;
                    o.Alpha = tex.a * _FrontColor.a;
                    o.Specular = _FrontShininess;
                    o.Normal = UnpackNormal(tex2D(_FrontBumpMap, IN.uv_FrontBumpMap));
                }
     else {
                    // 反面
                    fixed4 tex = tex2D(_BackMainTex, IN.uv_BackMainTex);
                    o.Albedo = tex.rgb * _BackColor.rgb;
                    o.Gloss = tex.a;
                    o.Alpha = tex.a * _BackColor.a;
                    o.Specular = _BackShininess;
                    o.Normal = UnpackNormal(tex2D(_BackBumpMap, IN.uv_BackBumpMap));
                }
            }
            ENDCG

            Cull Front

            CGPROGRAM
            #pragma surface surf BlinnPhong

            sampler2D _FrontMainTex;
            sampler2D _FrontBumpMap;
            fixed4 _FrontColor;
            half _FrontShininess;

            sampler2D _BackMainTex;
            sampler2D _BackBumpMap;
            fixed4 _BackColor;
            half _BackShininess;

            fixed _Flip;

            struct Input {
                float2 uv_FrontMainTex;
                float2 uv_FrontBumpMap;
                float2 uv_BackMainTex;
                float2 uv_BackBumpMap;
            };

            void surf(Input IN, inout SurfaceOutput o) {
                if (_Flip < 0.5) {
                    // 正面
                    fixed4 tex = tex2D(_BackMainTex, IN.uv_BackMainTex);
                    o.Albedo = tex.rgb * _BackColor.rgb;
                    o.Gloss = tex.a;
                    o.Alpha = tex.a * _BackColor.a;
                    o.Specular = _BackShininess;
                    o.Normal = UnpackNormal(tex2D(_BackBumpMap, IN.uv_BackBumpMap));
                }
     else {
                    // 反面
                    fixed4 tex = tex2D(_FrontMainTex, IN.uv_FrontMainTex);
                    o.Albedo = tex.rgb * _FrontColor.rgb;
                    o.Gloss = tex.a;
                    o.Alpha = tex.a * _FrontColor.a;
                    o.Specular = _FrontShininess;
                    o.Normal = UnpackNormal(tex2D(_FrontBumpMap, IN.uv_FrontBumpMap));
                }
            }
            ENDCG
        }

            Fallback "Specular"
}

