Shader "Unlit/InteractiveTextShader"
{
    Properties
    {
        _MainTex ("Base (RGB)", 2D) = "white" {}
        _Color ("Text Color", Color) = (1, 1, 1, 1)
    }
    SubShader
    {
        Tags { "Queue" = "Overlay" }
        ZTest Always
        ZWrite Off
        Lighting Off
        Fog { Mode Off }
        Cull Off
        Blend One OneMinusSrcAlpha
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 texcoord : TEXCOORD0;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                float2 texcoord : TEXCOORD0;
            };

            sampler2D _MainTex;
            float4 _Color;

            v2f vert (appdata_t v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.texcoord = v.texcoord;
                return o;
            }

            half4 frag (v2f i) : SV_Target
            {
                half4 texColor = tex2D(_MainTex, i.texcoord);
                return texColor * _Color;
            }
            ENDCG
        }
    }
    FallBack "Unlit/Transparent"
}
