Shader "Custom/0502_1" {
	Properties {

		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_BumpMap("Normal", 2D) = "bump" {}
		_Cube("Cube", cube) = "" {}

	}
	SubShader {
		Tags { "RenderType"="Opaque" "Queue"="Transparent"}
		LOD 200


		CGPROGRAM
		#pragma surface surf YDS alpha:fade vertex:vert
		void vert(inout appdata_full v){
		v.vertex.z += sin((abs(v.texcoord.x * 2 - 1) * 5)+ _Time.y) * 0.03;
		v.vertex.z += sin((abs(v.texcoord.y * 2 - 1) * 5)+ _Time.y) * 0.02;
		}


		sampler2D _MainTex;
		sampler2D _BumpMap;
		sampler2D _GrabTexture;
		samplerCUBE _Cube;

		struct Input {

			float2 uv_MainTex;
			float2 uv_BumpMap;
			float3 worldRefl;
			float3 viewDir;
			float4 screenPos;
			INTERNAL_DATA
		};

		void surf (Input IN, inout SurfaceOutput o) {
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
			float3 Normal1 = UnpackNormal(tex2D(_BumpMap, float2(IN.uv_BumpMap.r + _Time.x * 0.15,IN.uv_BumpMap.g)));
			float3 Normal2 = UnpackNormal(tex2D(_BumpMap, float2(IN.uv_BumpMap.r, IN.uv_BumpMap.g + _Time.x * 0.25)));
			o.Normal = (Normal1 + Normal2)/2;
			float rim = dot(o.Normal,IN.viewDir);

			float4 Reflec = texCUBE(_Cube, WorldReflectionVector(IN,o.Normal));
			o.Emission = lerp (Reflec,c.rgb, rim);
			//o.Emission = rim;
			//o.Alpha = 1;
			o.Alpha = saturate(pow(1-rim, 3 )+0.5);
		}
		float4 LightingYDS (SurfaceOutput s , float3 lightDir, float3 viewDir, float atten) {
			float3 H = normalize(viewDir + lightDir);
			float spec = saturate(dot(H,s.Normal));
			spec = pow (spec, 300);
			float3 specColor = spec * 2;
		return float4(specColor, spec + s.Alpha);


		}



		ENDCG
	}
	FallBack "Diffuse"
}
