﻿
namespace Sider.Executors
{
  public class ImmediateExecutor : ExecutorBase
  {
    public ImmediateExecutor(RedisSettings settings,
      ProtocolReader reader, ProtocolWriter writer) :
      base(settings, reader, writer) { }


    public override T Execute<T>(Invocation<T> invocation)
    {
      invocation.WriteAction(Writer);
      return invocation.ReadAction(Reader);
    }
  }
}