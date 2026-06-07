public static class TelemetryBuffer
{
    private const byte USHORT_PREFIX = 2;
    private const byte UINT_PREFIX = 4;
    private const byte SHORT_PREFIX = 254;
    private const byte INT_PREFIX = 252;
    private const byte LONG_PREFIX = 248;

    public static byte[] ToBuffer(long reading)
    {
        (byte prefix, byte[] bytes) = reading switch
        {
            < int.MinValue => (LONG_PREFIX, BitConverter.GetBytes(reading)),
            < short.MinValue => (INT_PREFIX, BitConverter.GetBytes((int)reading)),
            < ushort.MinValue => (SHORT_PREFIX, BitConverter.GetBytes((short)reading)),
            <= ushort.MaxValue => (USHORT_PREFIX, BitConverter.GetBytes((ushort)reading)),
            <= int.MaxValue => (INT_PREFIX, BitConverter.GetBytes((int)reading)),
            <= uint.MaxValue => (UINT_PREFIX, BitConverter.GetBytes((uint)reading)),
            _ => (LONG_PREFIX, BitConverter.GetBytes(reading))
        };

        var buffer = new byte[9];
        buffer[0] = prefix;

        for (var i = 0; i < bytes.Length; i++)
        {
            buffer[i + 1] = bytes[i];
        }

        return buffer;
    }

    public static long FromBuffer(byte[] buffer) => buffer[0] switch
    {
        USHORT_PREFIX => BitConverter.ToUInt16(buffer[1..buffer.Length]),
        UINT_PREFIX => BitConverter.ToUInt32(buffer[1..buffer.Length]),
        SHORT_PREFIX => BitConverter.ToInt16(buffer[1..buffer.Length]),
        INT_PREFIX => BitConverter.ToInt32(buffer[1..buffer.Length]),
        LONG_PREFIX => BitConverter.ToInt64(buffer[1..buffer.Length]),
        _ => 0
    };
}
