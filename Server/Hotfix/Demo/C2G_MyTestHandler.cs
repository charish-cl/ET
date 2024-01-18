using System;
namespace ET
{
    public class C2G_MyTestHandler : AMRpcHandler<C2G_MyTest, G2C_MyTest>
    {
        protected override async ETTask Run(Session session, C2G_MyTest request, G2C_MyTest response, Action reply)
        {
            response.Message = "这条是服务器返回的 C2G_MyTestHandler";
            reply();
            await ETTask.CompletedTask;
        }
    }
   
}