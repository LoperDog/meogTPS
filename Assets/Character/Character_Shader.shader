Shader "Custom/ChrShader" {
	Properties {

		_Color ("Color", Color) = (1,1,1,1)

		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_MetallicGlossMap ("MetalMap", 2D) = "white" {}

		_rimCol("RimColor", Color) = (1,1,1,1)
		_rimSel("RedBlue", Range(0,1)) = 0
		_rimPow("RimPower", Float) = 10


		_Glossiness ("Smoothness", Range(0,1)) = 0.6

	}
	SubShader {
		Tags { "RenderType"="Opaque" }

		

		CGPROGRAM
		#pragma surface surf Standard fullforwardshadows

		float4 _Color;

		sampler2D _MainTex;
		sampler2D _MetallicGlossMap;


		float _Glossiness;


		float _rimPow;
		float _rimSel;
		float4 _rimCol;




		struct Input {
			float2 uv_MainTex;
			float2 uv_MetallicGlossMap;
			float3 viewDir;
		};



		void surf (Input IN, inout SurfaceOutputStandard o) {

			//Texture
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			fixed4 m = tex2D(_MetallicGlossMap, IN.uv_MetallicGlossMap);


			//rimLight
			float rim = 1 - saturate(dot(o.Normal, normalize(IN.viewDir)));
			float4 rimC = float4(1 - _rimSel, 0, _rimSel, 1)*0.5;

			o.Albedo = c.rgb;
			o.Emission = pow(rim, _rimPow)*rimC;
			o.Metallic = m.a;
			o.Smoothness = _Glossiness;
			o.Alpha = 1;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
