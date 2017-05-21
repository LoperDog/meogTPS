Shader "Custom/Toon" {
	Properties {

		_MainTex ("Albedo (RGB)", 2D) = "white" {}

		_outline ("outline", float) = 0.05


		_RimL ("Rim값", float) = 0.5
		_RimC ("Rim칼라", Color) = (1,1,1,1)

		_spec ("spec", float) = 0.5
		_speCol("specColor", Color) = (1,1,1,1) 
		_glo("글로스값", float) = 0.5



	}
	SubShader {
		Tags { "RenderType"="Opaque" }

		cull back
		CGPROGRAM

		#pragma surface surf hyeon

		sampler2D _MainTex;


		float4 _speCol;
		float _spec;
		float _glo;

		float _RimL;
		float4 _RimC;


		struct Input {
			float2 uv_MainTex;


		};

		void surf (Input IN, inout SurfaceOutput o) {

			fixed4 c = tex2D (_MainTex, IN.uv_MainTex);



			o.Albedo = c.rgb;
			o.Alpha = c.a;
			o.Gloss = _glo;
		}

		float4 Lightinghyeon (SurfaceOutput s,float3 lightDir,float3 viewDir,float atten){

		//diff
		float3 diffCol;
		float NdotL = dot(s.Normal, lightDir)*0.5+0.5;
		//if
		if ( NdotL > 0.3)
		{
			NdotL = 1;
		}
		else
		{
			NdotL = 0.5;
		}
		diffCol = NdotL*s.Albedo*_LightColor0.rgb;

		//specular
		float3 speCol;
		float3 H = normalize( lightDir + viewDir );
		float spec = saturate ( dot( H, s.Normal ));
		spec = pow (spec, _spec);
		//if
		if (spec > 0.7)
		{
		spec = 0.8;
		}
		else
		{
		spec = 0;
		}

		speCol = spec * s.Gloss;


		/*//rim
		float Rim =dot(s.Normal, viewDir);
		Rim = pow(Rim , 0.7);


		if( Rim < 0.4)
		{
			Rim = 0;
		}
		else
		{
			Rim= 1;
		}
		float3 RimCol;
		RimCol = Rim;
		*/



		//final
		float4 finalColor;
		finalColor.rgb = (diffCol.rgb + speCol.rgb);
		finalColor.a = 1;




		return finalColor;
		}
		ENDCG

		// first pass
		cull front
		CGPROGRAM
		#pragma surface surf nolight vertex:vert noambient

		float _outline;

		void vert (inout appdata_full v) {
		v.vertex.xyz += v.normal.xyz * _outline;
		}

	

		struct Input {
			float4 color:COLOR;
		};

		fixed4 _Color;

		void surf (Input IN, inout SurfaceOutput o) {
			o.Alpha = 1;
		}
		float4 Lightingnolight ( SurfaceOutput s , float3 lightDir, float atten){
		return float4(0,0,0,s.Alpha);
		}
		ENDCG
	}
	FallBack "Diffuse"
}