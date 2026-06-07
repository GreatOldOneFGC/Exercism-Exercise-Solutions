public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte prefixByte;
        byte[] bytes;
        if (reading > int.MaxValue)
        {
            prefixByte = 248;
            bytes = [prefixByte, ..BitConverter.GetBytes(reading)];
        }
        else if (reading > short.MaxValue)
        {
            prefixByte = 252;
            bytes = [prefixByte, ..BitConverter.GetBytes((int)reading)];
        }
        else
        {
            prefixByte = 254;
            bytes = [prefixByte, ..BitConverter.GetBytes((short)reading)];
        }
        return bytes;
    }

    public static long FromBuffer(byte[] buffer)
    {
        var prefixByte = buffer[0];
        return prefixByte switch
        {
            2 => BitConverter.ToUInt16(buffer[1..buffer.Length]),
            4 => BitConverter.ToUInt32(buffer[1..buffer.Length]),
            8 => (long)BitConverter.ToUInt64(buffer[1..buffer.Length]),
            254 => BitConverter.ToUInt16(buffer[1..buffer.Length]),
            252 => BitConverter.ToInt32(buffer[1..buffer.Length]),
            248 => BitConverter.ToInt64(buffer[1..buffer.Length]),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
