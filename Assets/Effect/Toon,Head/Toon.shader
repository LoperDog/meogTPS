// Shader created with Shader Forge v1.36 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.36;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33009,y:32543,varname:node_3138,prsc:2|emission-6055-OUT,custl-5166-OUT,olwid-8506-OUT,olcol-5094-OUT;n:type:ShaderForge.SFN_LightVector,id:7731,x:31494,y:32505,varname:node_7731,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:9830,x:31494,y:32676,prsc:2,pt:False;n:type:ShaderForge.SFN_ViewVector,id:1156,x:31494,y:32873,varname:node_1156,prsc:2;n:type:ShaderForge.SFN_Dot,id:9707,x:31729,y:32789,varname:node_9707,prsc:2,dt:1|A-9830-OUT,B-1156-OUT;n:type:ShaderForge.SFN_Dot,id:360,x:31723,y:32495,varname:node_360,prsc:2,dt:1|A-7731-OUT,B-9830-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3657,x:31770,y:32661,ptovrint:False,ptlb:High_Light,ptin:_High_Light,varname:node_3657,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1.5;n:type:ShaderForge.SFN_ValueProperty,id:5933,x:31729,y:32977,ptovrint:False,ptlb:BRD,ptin:_BRD,varname:node_5933,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:1799,x:31928,y:32495,varname:node_1799,prsc:2|A-360-OUT,B-3657-OUT;n:type:ShaderForge.SFN_Power,id:4672,x:32099,y:32495,varname:node_4672,prsc:2|VAL-1799-OUT,EXP-3657-OUT;n:type:ShaderForge.SFN_Power,id:2532,x:31920,y:32789,varname:node_2532,prsc:2|VAL-9707-OUT,EXP-5933-OUT;n:type:ShaderForge.SFN_Color,id:7643,x:31909,y:32977,ptovrint:False,ptlb:LineColor,ptin:_LineColor,varname:node_7643,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Append,id:9298,x:32090,y:32789,varname:node_9298,prsc:2|A-2532-OUT,B-2532-OUT;n:type:ShaderForge.SFN_Add,id:9869,x:32307,y:32495,varname:node_9869,prsc:2|A-4672-OUT,B-7267-RGB;n:type:ShaderForge.SFN_Tex2d,id:7267,x:32307,y:32691,ptovrint:False,ptlb:ToonRamp,ptin:_ToonRamp,varname:node_7267,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:4a056241e2722dc46a7262a8e7073fd9,ntxv:0,isnm:False|UVIN-9298-OUT;n:type:ShaderForge.SFN_LightColor,id:7412,x:32307,y:32850,varname:node_7412,prsc:2;n:type:ShaderForge.SFN_Multiply,id:5166,x:32638,y:32567,varname:node_5166,prsc:2|A-9869-OUT,B-349-RGB,C-7412-RGB;n:type:ShaderForge.SFN_Tex2d,id:349,x:32324,y:32240,ptovrint:False,ptlb:tex,ptin:_tex,varname:node_349,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:1487f450b114c764cbc28cb15aa1590a,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:2602,x:32555,y:32257,varname:node_2602,prsc:2|A-349-RGB,B-3092-RGB;n:type:ShaderForge.SFN_Color,id:3092,x:32324,y:32066,ptovrint:False,ptlb:Main_Colour,ptin:_Main_Colour,varname:node_3092,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_AmbientLight,id:4504,x:32543,y:32076,varname:node_4504,prsc:2;n:type:ShaderForge.SFN_Multiply,id:6055,x:32737,y:32257,varname:node_6055,prsc:2|A-4504-RGB,B-2602-OUT;n:type:ShaderForge.SFN_Multiply,id:5094,x:32665,y:32917,varname:node_5094,prsc:2|A-349-RGB,B-7643-RGB;n:type:ShaderForge.SFN_ValueProperty,id:8506,x:32643,y:32824,ptovrint:False,ptlb:out,ptin:_out,varname:node_8506,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.02;proporder:3657-5933-7267-349-3092-8506-7643;pass:END;sub:END;*/

Shader "Shader Forge/NewShader" {
    Properties {
        _High_Light ("High_Light", Float ) = 1.5
        _BRD ("BRD", Float ) = 0.5
        _ToonRamp ("ToonRamp", 2D) = "white" {}
        _tex ("tex", 2D) = "white" {}
        _Main_Colour ("Main_Colour", Color) = (0.5,0.5,0.5,1)
        _out ("out", Float ) = 0.02
        _LineColor ("LineColor", Color) = (0.5,0.5,0.5,1)
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LineColor;
            uniform sampler2D _tex; uniform float4 _tex_ST;
            uniform float _out;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, float4(v.vertex.xyz + v.normal*_out,1) );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 _tex_var = tex2D(_tex,TRANSFORM_TEX(i.uv0, _tex));
                return fixed4((_tex_var.rgb*_LineColor.rgb),0);
            }
            ENDCG
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
            uniform float _High_Light;
            uniform float _BRD;
            uniform sampler2D _ToonRamp; uniform float4 _ToonRamp_ST;
            uniform sampler2D _tex; uniform float4 _tex_ST;
            uniform float4 _Main_Colour;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
////// Emissive:
                float4 _tex_var = tex2D(_tex,TRANSFORM_TEX(i.uv0, _tex));
                float3 emissive = (UNITY_LIGHTMODEL_AMBIENT.rgb*(_tex_var.rgb*_Main_Colour.rgb));
                float node_2532 = pow(max(0,dot(i.normalDir,viewDirection)),_BRD);
                float2 node_9298 = float2(node_2532,node_2532);
                float4 _ToonRamp_var = tex2D(_ToonRamp,TRANSFORM_TEX(node_9298, _ToonRamp));
                float3 finalColor = emissive + ((pow((max(0,dot(lightDirection,i.normalDir))*_High_Light),_High_Light)+_ToonRamp_var.rgb)*_tex_var.rgb*_LightColor0.rgb);
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
            uniform float _High_Light;
            uniform float _BRD;
            uniform sampler2D _ToonRamp; uniform float4 _ToonRamp_ST;
            uniform sampler2D _tex; uniform float4 _tex_ST;
            uniform float4 _Main_Colour;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float node_2532 = pow(max(0,dot(i.normalDir,viewDirection)),_BRD);
                float2 node_9298 = float2(node_2532,node_2532);
                float4 _ToonRamp_var = tex2D(_ToonRamp,TRANSFORM_TEX(node_9298, _ToonRamp));
                float4 _tex_var = tex2D(_tex,TRANSFORM_TEX(i.uv0, _tex));
                float3 finalColor = ((pow((max(0,dot(lightDirection,i.normalDir))*_High_Light),_High_Light)+_ToonRamp_var.rgb)*_tex_var.rgb*_LightColor0.rgb);
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
