﻿namespace OSDP.Net.Tracing;

internal class DummyTracer : ITracer
{
    public void Dispose() { }

    public void Trace(TraceEntry trace) { }

    public readonly static DummyTracer Default = new DummyTracer();
}
