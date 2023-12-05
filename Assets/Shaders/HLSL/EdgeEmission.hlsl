#ifndef EDGE_EMISSION_INCLUDED
#define EDGE_EMISSION_INCLUDED

// Helper functions
float remap(float value, float2 inMinMax, float2 outMinMax) 
{
    return outMinMax.x + (value - inMinMax.x) * (outMinMax.y - outMinMax.x) / (inMinMax.y - inMinMax.x);
}

float step(float edge, float x)
{
    return x < edge ? 0.0 : 1.0;
}

float smoothstep(float edge0, float edge1, float x) 
{
    float t = saturate((x - edge0) / (edge1 - edge0));
    return t * t * (3.0 - 2.0 * t);
}

float SG_LerpClamp(
    float2 UV, 
    float LerpHeight, 
    float LerpThreshold, 
    float LerpFeathering
)
{
    // UV座標にタイリングとオフセットを適用
    float2 tilingAndOffset = UV.xy * float2(1, 1) + float2(LerpThreshold, LerpThreshold);

    // tilingAndOffsetのY成分を基に計算
    float oneMinusG = 1.0 - tilingAndOffset.y;
    float stepResult = tilingAndOffset.y < 1.0 ? 0.0 : 1.0;
    float oneMinusStep = 1.0 - stepResult;

    // LerpHeightを0から1の範囲にリマップ
    float remappedLerpHeight = remap(LerpHeight, float2(-1, 1), float2(0, 1));

    // スムーズステップを適用して補間
    float smoothstepResult = smoothstep(oneMinusG, oneMinusStep, remappedLerpHeight);

    // スムーズステップの結果をさらにステップ結果で乗算
    float multipliedResult = smoothstepResult * stepResult;

    // 最終的な補間値をスムーズステップで計算
    return smoothstep(0, LerpFeathering, multipliedResult);
}

float4 SG_ColorLerp(
    float2 UV, 
    float LerpHeight, 
    float LerpThreshold, 
    float LerpFeathering, 
    float4 Colour, 
    float4 LerpColour, 
    float Dissolve
)
{
    // SG_LerpClamp関数を使用してクランプされた補間係数を計算
    float clampedLerpFactor = SG_LerpClamp(UV, LerpHeight, LerpThreshold, LerpFeathering);

    // Dissolve に基づいて色を補間
    float lerpFactor = Dissolve - LerpThreshold;
    float finalLerpFactor = clamp(lerpFactor, 0.0, 1.0);

    // 色を補間
    return lerp(Colour, LerpColour, finalLerpFactor);
}

float SG_RelativeScale(float EdgeHeight)
{
    // モデルのY軸に沿ったスケールを取得
    float modelScaleY = length(float3(UNITY_MATRIX_M[0].y, UNITY_MATRIX_M[1].y, UNITY_MATRIX_M[2].y));

    // エッジの高さをモデルのスケールに合わせて調整
    return EdgeHeight / modelScaleY;
}

void EdgeEmission_float(
    float2 UVEdge, 
    float Pattern, 
    float EdgeWidth, 
    float EdgeWidthMult, 
    float HeightValue, 
    float EdgeIntensity, 
    float Dissolve, 
    float2 DissolveRange, 
    float EdgeLerpHeight, 
    float EdgeLerpFeathering, 
    float4 EdgeColor, 
    float4 EdgeLerpColor, 
    float EdgeLerpThreshold, 
    float OneMinus, 
    out float4 Out_Color
)
{
    // DissolveRangeを使用してDissolve値をリマップ
    float remappedDissolve = remap(Dissolve, float2(-1, 1), DissolveRange);

    // カラーレルプの計算
    float4 colorLerpResult = SG_ColorLerp(
        UVEdge, 
        EdgeLerpHeight, 
        EdgeLerpThreshold, 
        EdgeLerpFeathering, 
        EdgeColor, 
        EdgeLerpColor, 
        Dissolve
    );

    // EdgeWidthの相対値を計算

    float3 objectScale = float3(
        length(float3(UNITY_MATRIX_M[0].x, UNITY_MATRIX_M[1].x, UNITY_MATRIX_M[2].x)),
        length(float3(UNITY_MATRIX_M[0].y, UNITY_MATRIX_M[1].y, UNITY_MATRIX_M[2].y)),
        length(float3(UNITY_MATRIX_M[0].z, UNITY_MATRIX_M[1].z, UNITY_MATRIX_M[2].z))
    );
    float3 relativeEdgeWidth = (EdgeWidth * EdgeWidthMult) / objectScale;

    // 高さに基づくスケール値を計算
    float adjustedHeightValue = SG_RelativeScale(HeightValue);
    if (adjustedHeightValue <= 0)
    {
        adjustedHeightValue = 0.0001;
    }
    relativeEdgeWidth = relativeEdgeWidth / adjustedHeightValue;
    relativeEdgeWidth = relativeEdgeWidth + remappedDissolve;

    float3 stepResult = step(float3(Pattern, Pattern, Pattern), relativeEdgeWidth);

    stepResult = OneMinus ? (float4(1, 1, 1, 1) - stepResult) : stepResult;

        // 色の強度を調整
    float4 intensityModulatedColor = colorLerpResult * EdgeIntensity;

    // stepResultを適用して最終出力を生成 // * float4(stepResult, 1.0);
    Out_Color = float4(intensityModulatedColor.rgb, 1.0) * float4(stepResult, 1.0);
}
#endif