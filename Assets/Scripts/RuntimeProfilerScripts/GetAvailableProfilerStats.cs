using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;

namespace PlateauSamples.MiniatureViewer
{
    public class GetAvailableProfilerStats
    {
        /***********************************************************************************************************************************************
        * Source: https://docs.unity3d.com/2020.2/Documentation/ScriptReference/Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle.GetAvailable.html
        ************************************************************************************************************************************************/
        struct StatInfo
        {
            public ProfilerCategory m_Cat;
            public string m_Name;
            public ProfilerMarkerDataUnit m_Unit;
        }

        public static void EnumerateProfilerStats()
        {
            var availableStatHandles = new List<ProfilerRecorderHandle>();
            ProfilerRecorderHandle.GetAvailable(availableStatHandles);

            var availableStats = new List<StatInfo>(availableStatHandles.Count);
            foreach (ProfilerRecorderHandle h in availableStatHandles)
            {
                ProfilerRecorderDescription statDesc = ProfilerRecorderHandle.GetDescription(h);
                var statInfo = new StatInfo()
                {
                    m_Cat = statDesc.Category,
                    m_Name = statDesc.Name,
                    m_Unit = statDesc.UnitType
                };
                availableStats.Add(statInfo);
            }
            availableStats.Sort((a, b) =>
            {
                int result = string.Compare(a.m_Cat.ToString(), b.m_Cat.ToString());
                return result != 0 ? result : string.Compare(a.m_Name, b.m_Name);
            });

            var sb = new StringBuilder("Available stats:\n");
            foreach (StatInfo s in availableStats)
            {
                sb.AppendLine($"{s.m_Cat.ToString()}\t\t - {s.m_Name}\t\t - {s.m_Unit}");
            }

            FileManager.WriteToFile("AvailableStats.txt", sb.ToString());
            Debug.Log(sb.ToString());
        }
    }
}