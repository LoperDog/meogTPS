// Shader created with Shader Forge v1.36 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.36;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.07369161,fgcg:0.1035251,fgcb:0.2132353,fgca:1,fgde:0.01,fgrn:0,fgrf:500,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:34362,y:32871,varname:node_3138,prsc:2|diff-8953-OUT,spec-8580-OUT,normal-4908-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:32309,y:33090,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.7441832,c2:0.7941176,c3:0.6773356,c4:1;n:type:ShaderForge.SFN_ViewVector,id:606,x:31746,y:32694,varname:node_606,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:1168,x:31746,y:32846,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:7087,x:31933,y:32752,varname:node_7087,prsc:2,dt:0|A-606-OUT,B-1168-OUT;n:type:ShaderForge.SFN_Tex2d,id:7842,x:32536,y:32993,ptovrint:False,ptlb:Tex,ptin:_Tex,varname:node_7842,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:1bc15a0d2d34496409b675bc3910fa0d,ntxv:0,isnm:False;n:type:ShaderForge.SFN_OneMinus,id:8915,x:32311,y:32738,varname:node_8915,prsc:2|IN-6707-OUT;n:type:ShaderForge.SFN_Add,id:8953,x:33727,y:32847,varname:node_8953,prsc:2|A-442-OUT,B-947-OUT;n:type:ShaderForge.SFN_Clamp01,id:394,x:32638,y:32785,varname:node_394,prsc:2|IN-6224-OUT;n:type:ShaderForge.SFN_Multiply,id:6224,x:32475,y:32785,varname:node_6224,prsc:2|A-6707-OUT,B-9132-RGB;n:type:ShaderForge.SFN_Color,id:9132,x:32311,y:32902,ptovrint:False,ptlb:Rim Color,ptin:_RimColor,varname:node_9132,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8823529,c2:0.8823529,c3:0.8823529,c4:1;n:type:ShaderForge.SFN_Multiply,id:5379,x:33199,y:32887,varname:node_5379,prsc:2|A-3644-OUT,B-8084-OUT;n:type:ShaderForge.SFN_Tex2d,id:7882,x:33071,y:32648,ptovrint:False,ptlb:Normal,ptin:_Normal,varname:node_7882,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:378f02e0957f6f44b817c71dec6574fe,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Multiply,id:3644,x:32777,y:33026,varname:node_3644,prsc:2|A-7842-RGB,B-4159-OUT;n:type:ShaderForge.SFN_Lerp,id:4159,x:32536,y:33215,varname:node_4159,prsc:2|A-7241-RGB,B-4557-RGB,T-92-RGB;n:type:ShaderForge.SFN_Color,id:4557,x:32309,y:33269,ptovrint:False,ptlb:Color2,ptin:_Color2,varname:node_4557,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.375,c2:0.2338235,c3:0.05514707,c4:1;n:type:ShaderForge.SFN_Tex2d,id:92,x:32309,y:33436,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:node_92,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Power,id:6707,x:32111,y:32752,varname:node_6707,prsc:2|VAL-7087-OUT,EXP-1429-OUT;n:type:ShaderForge.SFN_Tex2d,id:1319,x:33315,y:32388,ptovrint:False,ptlb:node_1319,ptin:_node_1319,varname:node_1319,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2b837a5587cd1a7439d2daf0c915761a,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:442,x:32812,y:32759,varname:node_442,prsc:2|A-2585-OUT,B-394-OUT;n:type:ShaderForge.SFN_Vector1,id:2585,x:32560,y:32674,varname:node_2585,prsc:2,v1:0.3;n:type:ShaderForge.SFN_ValueProperty,id:4134,x:33315,y:32607,ptovrint:False,ptlb:Speculr Pow,ptin:_SpeculrPow,varname:node_4134,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_ValueProperty,id:8084,x:32970,y:33060,ptovrint:False,ptlb:node_8084,ptin:_node_8084,varname:node_8084,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:1429,x:31918,y:32935,ptovrint:False,ptlb:Rim Pow,ptin:_RimPow,varname:node_1429,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Clamp01,id:5113,x:33368,y:32887,varname:node_5113,prsc:2|IN-5379-OUT;n:type:ShaderForge.SFN_Color,id:9416,x:33368,y:33063,ptovrint:False,ptlb:final Color,ptin:_finalColor,varname:node_9416,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:947,x:33542,y:32937,varname:node_947,prsc:2|A-5113-OUT,B-9416-RGB;n:type:ShaderForge.SFN_Lerp,id:4908,x:33315,y:32692,varname:node_4908,prsc:2|A-6682-OUT,B-7882-RGB,T-4730-OUT;n:type:ShaderForge.SFN_Vector3,id:6682,x:33071,y:32539,varname:node_6682,prsc:2,v1:0,v2:0,v3:1;n:type:ShaderForge.SFN_ValueProperty,id:4730,x:33071,y:32817,ptovrint:False,ptlb:Normal Pow,ptin:_NormalPow,varname:node_4730,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Multiply,id:8580,x:33519,y:32544,varname:node_8580,prsc:2|A-1319-A,B-4134-OUT;n:type:ShaderForge.SFN_Slider,id:1835,x:33910,y:32677,ptovrint:False,ptlb:node_1835,ptin:_node_1835,varname:node_1835,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;proporder:9132-7842-7882-7241-4557-92-1319-4134-8084-1429-9416-4730-1835;pass:END;sub:END;*/

Shader "Shader Forge/NewShader" {
    Properties {
        _RimColor ("Rim Color", Color) = (0.8823529,0.8823529,0.8823529,1)
        _Tex ("Tex", 2D) = "white" {}
        _Normal ("Normal", 2D) = "bump" {}
        _Color ("Color", Color) = (0.7441832,0.7941176,0.6773356,1)
        _Color2 ("Color2", Color) = (0.375,0.2338235,0.05514707,1)
        _Noise ("Noise", 2D) = "white" {}
        _node_1319 ("node_1319", 2D) = "white" {}
        _SpeculrPow ("Speculr Pow", Float ) = 0.1
        _node_8084 ("node_8084", Float ) = 1
        _RimPow ("Rim Pow", Float ) = 2
        _finalColor ("final Color", Color) = (0.5,0.5,0.5,1)
        _NormalPow ("Normal Pow", Float ) = 0.2
        _node_1835 ("node_1835", Range(0, 1)) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float4 _Color;
            uniform sampler2D _Tex; uniform float4 _Tex_ST;
            uniform float4 _RimColor;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float4 _Color2;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform sampler2D _node_1319; uniform float4 _node_1319_ST;
            uniform float _SpeculrPow;
            uniform float _node_8084;
            uniform float _RimPow;
            uniform float4 _finalColor;
            uniform float _NormalPow;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normal_var = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(i.uv0, _Normal)));
                float3 normalLocal = lerp(float3(0,0,1),_Normal_var.rgb,_NormalPow);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float4 _node_1319_var = tex2D(_node_1319,TRANSFORM_TEX(i.uv0, _node_1319));
                float node_8580 = (_node_1319_var.a*_SpeculrPow);
                float3 specularColor = float3(node_8580,node_8580,node_8580);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float node_6707 = pow(dot(viewDirection,i.normalDir),_RimPow);
                float4 _Tex_var = tex2D(_Tex,TRANSFORM_TEX(i.uv0, _Tex));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float3 diffuseColor = ((0.3*saturate((node_6707*_RimColor.rgb)))+(saturate(((_Tex_var.rgb*lerp(_Color.rgb,_Color2.rgb,_Noise_var.rgb))*_node_8084))*_finalColor.rgb));
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float4 _Color;
            uniform sampler2D _Tex; uniform float4 _Tex_ST;
            uniform float4 _RimColor;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float4 _Color2;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform sampler2D _node_1319; uniform float4 _node_1319_ST;
            uniform float _SpeculrPow;
            uniform float _node_8084;
            uniform float _RimPow;
            uniform float4 _finalColor;
            uniform float _NormalPow;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normal_var = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(i.uv0, _Normal)));
                float3 normalLocal = lerp(float3(0,0,1),_Normal_var.rgb,_NormalPow);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float4 _node_1319_var = tex2D(_node_1319,TRANSFORM_TEX(i.uv0, _node_1319));
                float node_8580 = (_node_1319_var.a*_SpeculrPow);
                float3 specularColor = float3(node_8580,node_8580,node_8580);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float node_6707 = pow(dot(viewDirection,i.normalDir),_RimPow);
                float4 _Tex_var = tex2D(_Tex,TRANSFORM_TEX(i.uv0, _Tex));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float3 diffuseColor = ((0.3*saturate((node_6707*_RimColor.rgb)))+(saturate(((_Tex_var.rgb*lerp(_Color.rgb,_Color2.rgb,_Noise_var.rgb))*_node_8084))*_finalColor.rgb));
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
