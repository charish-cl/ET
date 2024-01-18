using System;
using ET.EventType;

namespace ET
{
    public class AppStartInitFinish_CreateLoginUI: AEvent<EventType.AppStartInitFinish>
    {
        protected override void Run(EventType.AppStartInitFinish args)
        {
            UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid).Coroutine();

            Test(args.ZoneScene);
        }

        private static async void Test(Scene ZoneScene)
        {
            Computer computer = ZoneScene.AddChild<Computer>();
            Game.EventSystem.Publish(new EventType.InstallComputer() {Computer = computer});

       
            // computer.AddComponent<PCCaseComponent>();
            // computer.AddComponent<MonitorsComponent>();
            // computer.AddComponent<KeyboardComponent>();
            // computer.AddComponent<MouseComponent>();
            //
            // computer.Start();
            //
            // //await TimerComponent.Instance.WaitAsync(3000);
            //
            // computer.Dispose();
            // UnitConfig config = UnitConfigCategory.Instance.Get(1001);
            // Log.Info($"UnitConfigCategory.Instance.Get(1001): {JsonHelper.ToJson(config)}");
            // var allUnitConfig = UnitConfigCategory.Instance.GetAll();
            // foreach (var unitConfig in allUnitConfig)
            // {
            //     Log.Info($"UnitConfigCategory.Instance.GetAll(): {JsonHelper.ToJson(unitConfig)}");
            // }
        }
    }
}