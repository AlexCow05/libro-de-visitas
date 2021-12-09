using System;

internal class StreamReader
{
    public StreamReader(string v)
    {
        V = v;
    }

    public string V { get; }

    internal string ReadToEnd()
    {
        throw new NotImplementedException();
    }

    internal void Close()
    {
        throw new NotImplementedException();
    }
}