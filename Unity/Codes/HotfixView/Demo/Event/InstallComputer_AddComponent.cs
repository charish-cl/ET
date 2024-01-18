namespace ET
{
    public class InstallComputer_AddComponent:AEvent<EventType.InstallComputer>
    {
        protected override void Run(EventType.InstallComputer args)
        {
            args.Computer.AddComponent<PCCaseComponent>();
            args.Computer.AddComponent<MonitorsComponent>();
            args.Computer.AddComponent<KeyboardComponent>();
            args.Computer.AddComponent<MouseComponent>(); 
            
            args.Computer.Start();
            Log.Info($"InstallComputer_AddComponent: {args.Computer.Id}");
            this.Test().Coroutine();
            ETCancellationToken cancellationToken = new ETCancellationToken();
            
            cancellationToken.Cancel();
        }
        
        public async ETTask<int> Test()
        {
            await TimerComponent.Instance.WaitAsync(3000);
            return 1;
        }
    }
 
}