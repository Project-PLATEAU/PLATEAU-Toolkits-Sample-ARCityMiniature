using System.Collections.Generic;
using System.Text;
using Unity.Profiling;
using UnityEngine;

namespace PlateauSamples.MiniatureViewer
{
    public class ProfilerController : MonoBehaviour
    {
        /************************************************************************************************************
        * Source: https://docs.unity3d.com/2020.2/Documentation/ScriptReference/Unity.Profiling.ProfilerRecorder.html
        *************************************************************************************************************/

        //public static ProfilerMarker UpdatePlayerProfilerMarker = new ProfilerMarker("Player.Update");

        string m_StatsText;
        ProfilerRecorder m_SystemMemoryRecorder;
        ProfilerRecorder m_GcMemoryRecorder;
        ProfilerRecorder m_MainThreadTimeRecorder;
        ProfilerRecorder m_DrawCallsCountRecorder;
        ProfilerRecorder m_SetPassCallsRecorder;
        ProfilerRecorder m_TrianglesRecorder;
        ProfilerRecorder m_VerticesRecorder;

        static double GetRecorderFrameAverage(ProfilerRecorder recorder)
        {
            int samplesCount = recorder.Capacity;
            if (samplesCount == 0)
            {
                return 0;
            }

            double r = 0;
            var samples = new List<ProfilerRecorderSample>(samplesCount);
            recorder.CopyTo(samples);
            for (int i = 0; i < samples.Count; ++i)
            {
                r += samples[i].Value;
            }

            r /= samplesCount;

            return r;
        }

        void OnEnable()
        {
            m_SystemMemoryRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Memory, "System Used Memory");
            m_GcMemoryRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Memory, "GC Reserved Memory");
            m_MainThreadTimeRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Internal, "Main Thread", 15);
            m_TrianglesRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Render, "Triangles Count");
            m_VerticesRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Render, "Vertices Count");
            m_DrawCallsCountRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Render, "Draw Calls Count");
            m_SetPassCallsRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Render, "SetPass Calls Count");

            GetAvailableProfilerStats.EnumerateProfilerStats();
        }

        void OnDisable()
        {
            m_SystemMemoryRecorder.Dispose();
            m_GcMemoryRecorder.Dispose();
            m_MainThreadTimeRecorder.Dispose();
            m_DrawCallsCountRecorder.Dispose();
            m_SetPassCallsRecorder.Dispose();
        }
        void Update()
        {
            // Calculate FPS based on the last frame time
            float lastFrameTime = m_MainThreadTimeRecorder.LastValue * (1e-9f); // Last frame time in seconds (nanoseconds to seconds)
            float fps = 1f / lastFrameTime; // FPS is the inverse of the frame time in seconds

            int systemMemorySize = SystemInfo.systemMemorySize;

            // Continue with the existing StringBuilder code
            var sb = new StringBuilder(500);
            sb.AppendLine($"Frame Time: {lastFrameTime * 1000:F1} ms"); // Convert to milliseconds for display
            sb.AppendLine($"FPS: {fps:F1}");
            sb.AppendLine($"GC Memory: {m_GcMemoryRecorder.LastValue / (1024 * 1024)} MB");
            sb.AppendLine($"System Memory: {m_SystemMemoryRecorder.LastValue / (1024 * 1024)} MB");
            sb.AppendLine($"Triangles Count: {m_TrianglesRecorder.LastValue}");
            sb.AppendLine($"Vertices Count: {m_VerticesRecorder.LastValue}");
            sb.AppendLine($"Draw Calls: {m_DrawCallsCountRecorder.LastValue}");
            sb.AppendLine($"SetPass Calls: {m_SetPassCallsRecorder.LastValue}");
            sb.AppendLine($"Screen Width: {Screen.width}px");
            sb.AppendLine($"Screen Height: {Screen.height}px");
            sb.AppendLine($"RAM: {systemMemorySize} MB");
            m_StatsText = sb.ToString();
        }
        void OnGUI()
        {
            GUIStyle textStyle = new GUIStyle();
            textStyle.fontSize = 30;
            textStyle.normal.textColor = Color.green;

            GUI.TextArea(new Rect(10, 30, 250, 200), m_StatsText, textStyle);
        }
    }
}
