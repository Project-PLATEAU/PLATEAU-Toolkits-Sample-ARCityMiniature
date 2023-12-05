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
    // UV���W�Ƀ^�C�����O�ƃI�t�Z�b�g��K�p
    float2 tilingAndOffset = UV.xy * float2(1, 1) + float2(LerpThreshold, LerpThreshold);

    // tilingAndOffset��Y��������Ɍv�Z
    float oneMinusG = 1.0 - tilingAndOffset.y;
    float stepResult = tilingAndOffset.y < 1.0 ? 0.0 : 1.0;
    float oneMinusStep = 1.0 - stepResult;

    // LerpHeight��0����1�͈̔͂Ƀ��}�b�v
    float remappedLerpHeight = remap(LerpHeight, float2(-1, 1), float2(0, 1));

    // �X���[�Y�X�e�b�v��K�p���ĕ��
    float smoothstepResult = smoothstep(oneMinusG, oneMinusStep, remappedLerpHeight);

    // �X���[�Y�X�e�b�v�̌��ʂ�����ɃX�e�b�v���ʂŏ�Z
    float multipliedResult = smoothstepResult * stepResult;

    // �ŏI�I�ȕ�Ԓl���X���[�Y�X�e�b�v�Ōv�Z
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
    // SG_LerpClamp�֐����g�p���ăN�����v���ꂽ��ԌW�����v�Z
    float clampedLerpFactor = SG_LerpClamp(UV, LerpHeight, LerpThreshold, LerpFeathering);

    // Dissolve �Ɋ�Â��ĐF����
    float lerpFactor = Dissolve - LerpThreshold;
    float finalLerpFactor = clamp(lerpFactor, 0.0, 1.0);

    // �F����
    return lerp(Colour, LerpColour, finalLerpFactor);
}

float SG_RelativeScale(float EdgeHeight)
{
    // ���f����Y���ɉ������X�P�[�����擾
    float modelScaleY = length(float3(UNITY_MATRIX_M[0].y, UNITY_MATRIX_M[1].y, UNITY_MATRIX_M[2].y));

    // �G�b�W�̍��������f���̃X�P�[���ɍ��킹�Ē���
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
    // DissolveRange���g�p����Dissolve�l�����}�b�v
    float remappedDissolve = remap(Dissolve, float2(-1, 1), DissolveRange);

    // �J���[�����v�̌v�Z
    float4 colorLerpResult = SG_ColorLerp(
        UVEdge, 
        EdgeLerpHeight, 
        EdgeLerpThreshold, 
        EdgeLerpFeathering, 
        EdgeColor, 
        EdgeLerpColor, 
        Dissolve
    );

    // EdgeWidth�̑��Βl���v�Z

    float3 objectScale = float3(
        length(float3(UNITY_MATRIX_M[0].x, UNITY_MATRIX_M[1].x, UNITY_MATRIX_M[2].x)),
        length(float3(UNITY_MATRIX_M[0].y, UNITY_MATRIX_M[1].y, UNITY_MATRIX_M[2].y)),
        length(float3(UNITY_MATRIX_M[0].z, UNITY_MATRIX_M[1].z, UNITY_MATRIX_M[2].z))
    );
    float3 relativeEdgeWidth = (EdgeWidth * EdgeWidthMult) / objectScale;

    // �����Ɋ�Â��X�P�[���l���v�Z
    float adjustedHeightValue = SG_RelativeScale(HeightValue);
    if (adjustedHeightValue <= 0)
    {
        adjustedHeightValue = 0.0001;
    }
    relativeEdgeWidth = relativeEdgeWidth / adjustedHeightValue;
    relativeEdgeWidth = relativeEdgeWidth + remappedDissolve;

    float3 stepResult = step(float3(Pattern, Pattern, Pattern), relativeEdgeWidth);

    stepResult = OneMinus ? (float4(1, 1, 1, 1) - stepResult) : stepResult;

        // �F�̋��x�𒲐�
    float4 intensityModulatedColor = colorLerpResult * EdgeIntensity;

    // stepResult��K�p���čŏI�o�͂𐶐� // * float4(stepResult, 1.0);
    Out_Color = float4(intensityModulatedColor.rgb, 1.0) * float4(stepResult, 1.0);
}
#endif