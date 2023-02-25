Shader "Unlit/Chubric Shader"
{
    Properties
    {
        _Color ("Color", Color) = (1,3,2,1)
        _LightTime ("Health", Range(0, 10)) = 10
        _Opacity ("Health", Range(0, 1)) = 0.5
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent"}
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag


            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "AutoLight.cginc"

            float4 _Color;
            float _LightTime;
            float _Opacity;

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                float3 normal : NORMAL;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
                float3 normal : TEXCOORD1;
                float3 wPos : TEXCOORD2;
            };


            v2f vert (appdata v)
            {
                v2f o;
                o.normal = v.normal;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.wPos = mul(unity_ObjectToWorld, v.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float3 N = i.normal;
                float3 L = _WorldSpaceLightPos0.xyz;
                float3 diffuseLight = saturate(dot(N,L));

                //float3 V = normalize(_WorldSpaceCameraPos - i.wPos);
                //float3 R = reflect (-L, N);
                //float3 specularLight = saturate(dot(R,V));
                
                //return float4 (specularLight, 1);
                return float4 (diffuseLight, _Opacity);
            }
            ENDCG
