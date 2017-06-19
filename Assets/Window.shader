// Shader created with Shader Forge v1.36 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.36;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33110,y:32848,varname:node_3138,prsc:2|diff-7592-OUT,spec-6712-OUT,gloss-2974-OUT,emission-8737-OUT;n:type:ShaderForge.SFN_Tex2d,id:1136,x:31870,y:32625,ptovrint:False,ptlb:window,ptin:_window,varname:node_1136,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:dd50314d58368b644bd8e2b17e454f19,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:7592,x:32745,y:32954,varname:node_7592,prsc:2|A-4833-OUT,B-1047-OUT,T-1136-A;n:type:ShaderForge.SFN_Tex2d,id:9691,x:31624,y:33049,varname:node_9691,prsc:2,tex:f3cc7e33069224c4d8645bcbd1442cd3,ntxv:0,isnm:False|UVIN-1095-OUT,TEX-9289-TEX;n:type:ShaderForge.SFN_ValueProperty,id:2261,x:32047,y:32487,ptovrint:False,ptlb:Metallic_window,ptin:_Metallic_window,varname:node_2261,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.4;n:type:ShaderForge.SFN_ValueProperty,id:7624,x:32046,y:32762,ptovrint:False,ptlb:Gloss_Sky,ptin:_Gloss_Sky,varname:node_7624,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.3;n:type:ShaderForge.SFN_Color,id:101,x:31945,y:32808,ptovrint:False,ptlb:window_Color,ptin:_window_Color,varname:node_101,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Lerp,id:6712,x:32229,y:32537,varname:node_6712,prsc:2|A-2261-OUT,B-7965-OUT,T-1136-A;n:type:ShaderForge.SFN_ValueProperty,id:7965,x:32047,y:32571,ptovrint:False,ptlb:Metallic_Sky,ptin:_Metallic_Sky,varname:node_7965,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Lerp,id:2974,x:32469,y:32736,varname:node_2974,prsc:2|A-7530-OUT,B-7624-OUT,T-1136-A;n:type:ShaderForge.SFN_ValueProperty,id:7530,x:32046,y:32676,ptovrint:False,ptlb:Gloss_window,ptin:_Gloss_window,varname:_node_7624_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:4833,x:32124,y:32837,varname:node_4833,prsc:2|A-1136-RGB,B-101-RGB;n:type:ShaderForge.SFN_Color,id:9846,x:32138,y:33193,ptovrint:False,ptlb:Sky_Color2,ptin:_Sky_Color2,varname:_node_101_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8012171,c2:0.7941176,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:6168,x:32036,y:32131,ptovrint:False,ptlb:Base_Color_Window,ptin:_Base_Color_Window,varname:node_6168,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Lerp,id:2282,x:32373,y:33054,varname:node_2282,prsc:2|A-3217-OUT,B-9846-RGB,T-8247-OUT;n:type:ShaderForge.SFN_Tex2d,id:1160,x:31593,y:33392,varname:node_1160,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-3994-OUT,TEX-2879-TEX;n:type:ShaderForge.SFN_Power,id:3878,x:31905,y:33501,varname:node_3878,prsc:2|VAL-1160-RGB,EXP-4318-OUT;n:type:ShaderForge.SFN_Multiply,id:1047,x:32522,y:33054,varname:node_1047,prsc:2|A-2282-OUT,B-2246-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2246,x:32138,y:33420,ptovrint:False,ptlb:Sky Pow,ptin:_SkyPow,varname:node_2246,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_TexCoord,id:4712,x:30513,y:32896,varname:node_4712,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:6463,x:30504,y:33046,varname:node_6463,prsc:2;n:type:ShaderForge.SFN_Multiply,id:3290,x:30956,y:32923,varname:node_3290,prsc:2|A-6463-T,B-1028-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1028,x:30698,y:33015,ptovrint:False,ptlb:Speed1,ptin:_Speed1,varname:node_1028,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Add,id:5540,x:31139,y:32905,varname:node_5540,prsc:2|A-4712-U,B-3290-OUT;n:type:ShaderForge.SFN_Append,id:3994,x:31312,y:32905,varname:node_3994,prsc:2|A-4712-V,B-5540-OUT;n:type:ShaderForge.SFN_Multiply,id:5477,x:30942,y:32721,varname:node_5477,prsc:2|A-6463-T,B-1924-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1924,x:30722,y:32700,ptovrint:False,ptlb:Sky_Speed2,ptin:_Sky_Speed2,varname:_Speed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.02;n:type:ShaderForge.SFN_Add,id:9569,x:31125,y:32707,varname:node_9569,prsc:2|A-4712-U,B-5477-OUT;n:type:ShaderForge.SFN_Append,id:1095,x:31312,y:32707,varname:node_1095,prsc:2|A-4712-V,B-9569-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4318,x:31734,y:33511,ptovrint:False,ptlb:Noise_Pow,ptin:_Noise_Pow,varname:node_4318,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Tex2d,id:5553,x:31719,y:33621,varname:node_5553,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-6173-OUT,TEX-2879-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:2879,x:31341,y:33435,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:node_2879,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:8247,x:32241,y:33505,varname:node_8247,prsc:2|A-3878-OUT,B-5305-OUT;n:type:ShaderForge.SFN_Multiply,id:5305,x:31905,y:33700,varname:node_5305,prsc:2|A-5553-RGB,B-6696-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6696,x:31703,y:33780,ptovrint:False,ptlb:Noise_Pow2,ptin:_Noise_Pow2,varname:node_6696,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:1524,x:30966,y:33157,varname:node_1524,prsc:2|A-6463-T,B-9509-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9509,x:30710,y:33233,ptovrint:False,ptlb:Speed2,ptin:_Speed2,varname:_Speed3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-0.03;n:type:ShaderForge.SFN_Add,id:1472,x:31154,y:33123,varname:node_1472,prsc:2|A-4712-U,B-1524-OUT;n:type:ShaderForge.SFN_Append,id:6173,x:31312,y:33096,varname:node_6173,prsc:2|A-4712-V,B-1472-OUT;n:type:ShaderForge.SFN_Color,id:9226,x:32036,y:32303,ptovrint:False,ptlb:Base_Color_Sky,ptin:_Base_Color_Sky,varname:_node_6168_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Lerp,id:8737,x:32231,y:32243,varname:node_8737,prsc:2|A-6168-RGB,B-9226-RGB,T-1136-A;n:type:ShaderForge.SFN_Lerp,id:2325,x:31994,y:33110,varname:node_2325,prsc:2|A-4719-OUT,B-5059-OUT,T-3801-RGB;n:type:ShaderForge.SFN_Multiply,id:6980,x:30942,y:32584,varname:node_6980,prsc:2|A-491-OUT,B-6463-T;n:type:ShaderForge.SFN_Add,id:8663,x:31125,y:32569,varname:node_8663,prsc:2|A-4712-U,B-6980-OUT;n:type:ShaderForge.SFN_Append,id:116,x:31312,y:32555,varname:node_116,prsc:2|A-4712-V,B-8663-OUT;n:type:ShaderForge.SFN_Tex2d,id:6297,x:31654,y:32932,varname:node_6297,prsc:2,tex:f3cc7e33069224c4d8645bcbd1442cd3,ntxv:0,isnm:False|UVIN-116-OUT,TEX-9289-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:9289,x:31476,y:33010,ptovrint:False,ptlb:Sky,ptin:_Sky,varname:node_9289,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f3cc7e33069224c4d8645bcbd1442cd3,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:3801,x:31784,y:33309,varname:node_3801,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|TEX-2879-TEX;n:type:ShaderForge.SFN_ValueProperty,id:491,x:30722,y:32584,ptovrint:False,ptlb:Sky_Speed1,ptin:_Sky_Speed1,varname:node_491,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.01;n:type:ShaderForge.SFN_Multiply,id:3217,x:32157,y:33049,varname:node_3217,prsc:2|A-4299-OUT,B-2325-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4299,x:31994,y:33049,ptovrint:False,ptlb:node_4299,ptin:_node_4299,varname:node_4299,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.7;n:type:ShaderForge.SFN_Multiply,id:4719,x:31811,y:32896,varname:node_4719,prsc:2|A-8933-RGB,B-6297-RGB;n:type:ShaderForge.SFN_Color,id:8933,x:31640,y:32774,ptovrint:False,ptlb:node_8933,ptin:_node_8933,varname:node_8933,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9634516,c2:0.9926471,c3:0.7809797,c4:1;n:type:ShaderForge.SFN_Multiply,id:5059,x:31811,y:33110,varname:node_5059,prsc:2|A-9691-RGB,B-5047-RGB;n:type:ShaderForge.SFN_Color,id:5047,x:31624,y:33188,ptovrint:False,ptlb:node_5047,ptin:_node_5047,varname:node_5047,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.6764706,c3:0.6764706,c4:1;proporder:1136-2879-9289-6168-9226-101-9846-2261-7965-7530-7624-2246-491-1924-1028-9509-4318-6696-4299-8933-5047;pass:END;sub:END;*/

Shader "Shader Forge/q1" {
    Properties {
        _window ("window", 2D) = "white" {}
        _Noise ("Noise", 2D) = "white" {}
        _Sky ("Sky", 2D) = "white" {}
        _Base_Color_Window ("Base_Color_Window", Color) = (0,0,0,1)
        _Base_Color_Sky ("Base_Color_Sky", Color) = (0,0,0,1)
        _window_Color ("window_Color", Color) = (0,0,0,1)
        _Sky_Color2 ("Sky_Color2", Color) = (0.8012171,0.7941176,1,1)
        _Metallic_window ("Metallic_window", Float ) = 0.4
        _Metallic_Sky ("Metallic_Sky", Float ) = 1
        _Gloss_window ("Gloss_window", Float ) = 0.5
        _Gloss_Sky ("Gloss_Sky", Float ) = 0.3
        _SkyPow ("Sky Pow", Float ) = 0.5
        _Sky_Speed1 ("Sky_Speed1", Float ) = 0.01
        _Sky_Speed2 ("Sky_Speed2", Float ) = 0.02
        _Speed1 ("Speed1", Float ) = 0.1
        _Speed2 ("Speed2", Float ) = -0.03
        _Noise_Pow ("Noise_Pow", Float ) = 1
        _Noise_Pow2 ("Noise_Pow2", Float ) = 0.5
        _node_4299 ("node_4299", Float ) = 0.7
        _node_8933 ("node_8933", Color) = (0.9634516,0.9926471,0.7809797,1)
        _node_5047 ("node_5047", Color) = (1,0.6764706,0.6764706,1)
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
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _window; uniform float4 _window_ST;
            uniform float _Metallic_window;
            uniform float _Gloss_Sky;
            uniform float4 _window_Color;
            uniform float _Metallic_Sky;
            uniform float _Gloss_window;
            uniform float4 _Sky_Color2;
            uniform float4 _Base_Color_Window;
            uniform float _SkyPow;
            uniform float _Speed1;
            uniform float _Sky_Speed2;
            uniform float _Noise_Pow;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform float _Noise_Pow2;
            uniform float _Speed2;
            uniform float4 _Base_Color_Sky;
            uniform sampler2D _Sky; uniform float4 _Sky_ST;
            uniform float _Sky_Speed1;
            uniform float _node_4299;
            uniform float4 _node_8933;
            uniform float4 _node_5047;
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
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _window_var = tex2D(_window,TRANSFORM_TEX(i.uv0, _window));
                float gloss = lerp(_Gloss_window,_Gloss_Sky,_window_var.a);
                float perceptualRoughness = 1.0 - lerp(_Gloss_window,_Gloss_Sky,_window_var.a);
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = lerp(_Metallic_window,_Metallic_Sky,_window_var.a);
                float specularMonochrome;
                float4 node_6463 = _Time + _TimeEditor;
                float2 node_116 = float2(i.uv0.g,(i.uv0.r+(_Sky_Speed1*node_6463.g)));
                float4 node_6297 = tex2D(_Sky,TRANSFORM_TEX(node_116, _Sky));
                float2 node_1095 = float2(i.uv0.g,(i.uv0.r+(node_6463.g*_Sky_Speed2)));
                float4 node_9691 = tex2D(_Sky,TRANSFORM_TEX(node_1095, _Sky));
                float4 node_3801 = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float2 node_3994 = float2(i.uv0.g,(i.uv0.r+(node_6463.g*_Speed1)));
                float4 node_1160 = tex2D(_Noise,TRANSFORM_TEX(node_3994, _Noise));
                float2 node_6173 = float2(i.uv0.g,(i.uv0.r+(node_6463.g*_Speed2)));
                float4 node_5553 = tex2D(_Noise,TRANSFORM_TEX(node_6173, _Noise));
                float3 diffuseColor = lerp((_window_var.rgb*_window_Color.rgb),(lerp((_node_4299*lerp((_node_8933.rgb*node_6297.rgb),(node_9691.rgb*_node_5047.rgb),node_3801.rgb)),_Sky_Color2.rgb,(pow(node_1160.rgb,_Noise_Pow)*(node_5553.rgb*_Noise_Pow2)))*_SkyPow),_window_var.a); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float3 emissive = lerp(_Base_Color_Window.rgb,_Base_Color_Sky.rgb,_window_var.a);
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
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
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _window; uniform float4 _window_ST;
            uniform float _Metallic_window;
            uniform float _Gloss_Sky;
            uniform float4 _window_Color;
            uniform float _Metallic_Sky;
            uniform float _Gloss_window;
            uniform float4 _Sky_Color2;
            uniform float4 _Base_Color_Window;
            uniform float _SkyPow;
            uniform float _Speed1;
            uniform float _Sky_Speed2;
            uniform float _Noise_Pow;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform float _Noise_Pow2;
            uniform float _Speed2;
            uniform float4 _Base_Color_Sky;
            uniform sampler2D _Sky; uniform float4 _Sky_ST;
            uniform float _Sky_Speed1;
            uniform float _node_4299;
            uniform float4 _node_8933;
            uniform float4 _node_5047;
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
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _window_var = tex2D(_window,TRANSFORM_TEX(i.uv0, _window));
                float gloss = lerp(_Gloss_window,_Gloss_Sky,_window_var.a);
                float perceptualRoughness = 1.0 - lerp(_Gloss_window,_Gloss_Sky,_window_var.a);
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = lerp(_Metallic_window,_Metallic_Sky,_window_var.a);
                float specularMonochrome;
                float4 node_6463 = _Time + _TimeEditor;
                float2 node_116 = float2(i.uv0.g,(i.uv0.r+(_Sky_Speed1*node_6463.g)));
                float4 node_6297 = tex2D(_Sky,TRANSFORM_TEX(node_116, _Sky));
                float2 node_1095 = float2(i.uv0.g,(i.uv0.r+(node_6463.g*_Sky_Speed2)));
                float4 node_9691 = tex2D(_Sky,TRANSFORM_TEX(node_1095, _Sky));
                float4 node_3801 = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float2 node_3994 = float2(i.uv0.g,(i.uv0.r+(node_6463.g*_Speed1)));
                float4 node_1160 = tex2D(_Noise,TRANSFORM_TEX(node_3994, _Noise));
                float2 node_6173 = float2(i.uv0.g,(i.uv0.r+(node_6463.g*_Speed2)));
                float4 node_5553 = tex2D(_Noise,TRANSFORM_TEX(node_6173, _Noise));
                float3 diffuseColor = lerp((_window_var.rgb*_window_Color.rgb),(lerp((_node_4299*lerp((_node_8933.rgb*node_6297.rgb),(node_9691.rgb*_node_5047.rgb),node_3801.rgb)),_Sky_Color2.rgb,(pow(node_1160.rgb,_Noise_Pow)*(node_5553.rgb*_Noise_Pow2)))*_SkyPow),_window_var.a); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
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
