using System.Collections.Generic;

namespace MoreMultiPlayer;

public struct MultiInputPacket
{
    public Dictionary<int, InputPacket> inputPackets = new();

    public MultiInputPacket()
    {
    }

    public void Log()
    {
        Plugin.Log.LogInfo($"MultiInputPacket: {inputPackets.Count} input packets");
        foreach (var inputPacket in inputPackets)
        {
            Plugin.Log.LogInfo($"Player {inputPacket.Key}:");
            Plugin.Log.LogInfo($"seqNumber: {inputPacket.Value.seqNumber}");
            Plugin.Log.LogInfo($"joystickAngle: {inputPacket.Value.joystickAngle}");
            Plugin.Log.LogInfo($"jump: {inputPacket.Value.jump}");
            Plugin.Log.LogInfo($"ab1: {inputPacket.Value.ab1}");
            Plugin.Log.LogInfo($"ab2: {inputPacket.Value.ab2}");
            Plugin.Log.LogInfo($"ab3: {inputPacket.Value.ab3}");
            Plugin.Log.LogInfo($"start: {inputPacket.Value.start}");
            Plugin.Log.LogInfo($"select: {inputPacket.Value.select}");
            Plugin.Log.LogInfo($"w: {inputPacket.Value.w}");
            Plugin.Log.LogInfo($"a: {inputPacket.Value.a}");
            Plugin.Log.LogInfo($"s: {inputPacket.Value.s}");
            Plugin.Log.LogInfo($"d: {inputPacket.Value.d}");
            Plugin.Log.LogInfo($"targetDelayBufferSize: {inputPacket.Value.targetDelayBufferSize}");
        }
    }
}