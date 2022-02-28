// #define FACEBOOK_ANALYTICS
//
//
// using System.Collections.Generic;
// using Common.Analytics;
// using Common.Analytics.Providers;
// using UnityEngine;
//
// //using Firebase.Analytics;
//
// namespace AnalyticsPackage.Scripts
// {
//     public partial class AnalyticsController : Singleton<AnalyticsController>
//     {
//         private static readonly IList<IAnalyticProvider> providers = new List<IAnalyticProvider>();
//
//         private void Awake()
//         {
//             EnsureOneCopy();
//
//             InitFB();
//
//
//         }
//
//         private void InitFB()
//         {
//             if (!FB.IsInitialized)
//             {
//
//                 DLog("FB.Init");
//                 FB.Init(OnInitSDKComplete, OnHideDelegate);
//
//             }
//             else
//             {
//                 DLog("FB.ActivateApp");
//                 FB.ActivateApp();
//             }
//
//         }
//
//
//
//
//         private static void OnInitSDKComplete()
//         {
//             DLog("FB SDK OnInitSDKComplete");
//
//             if (FB.IsInitialized)
//             {
//                 // Signal an app activation App Event
//                 DLog("FB.ActivateApp()");
//                 FB.ActivateApp();
//
//                 OnGameActivated();
//
//             }
//             else
//             {
//                 Debug.Log("Failed to Initialize the Facebook SDK");
//             }
//         }
//
//         private void OnHideDelegate(bool isGameShown)
//         {
//             if (!isGameShown)
//             {
//                 Time.timeScale = 0;
//
//                 RawEvent("Application: Focus Lost", new Dictionary<string, object>
//                 {
//
//                 }, 0);
//
//             }
//             else
//             {
//                 Time.timeScale = 1;
//
//                 RawEvent("Application: Focus", new Dictionary<string, object>
//                 {
//
//                 }, 0);
//
//             }
//         }
//
//
//
//
//         //        private static bool IsEnable => GameManager.ReleaseBuild && GameManager.IsDevice && !GameManager.User.IsTester;
//         public static bool IsEnable => LoadingManager.IsDevice;
//
//
//         private static void OnGameActivated()
//         {
// #if  UNITY_EDITOR
//             if (AssetsManager.GeneralSettings.IsAnalyticsDebugging)
//             {
//                 providers.Add(new LogAnalyticsProvider());
//             }
// #endif
//
//             if (!Application.isEditor)
//             {
//                 providers.Add(new FacebookAnalyticsProvider());
//                 providers.Add(new AmplitudeAnalyticsProvider());
//                 providers.Add(new AppsflyerAnalyticsProvider());
//                 providers.Add(new AppMetricaAnalyticsProvider());
//
//                 // providers.Add(new GameAnalyticsProvider());
//                 // providers.Add(new TenjinAnalyticsProvider());
//             }
//
//         }
//
//         private void OnApplicationPause(bool pauseStatus)
//         {
//
//             foreach (var analyticProvider in providers)
//             {
//                 analyticProvider.OnApplicationPause(pauseStatus);
//             }
//
//         }
//
//         private static void Send(string eventName, Dictionary<string, object> data, int importanceCode)
//         {
//             DLog($"Send event:{eventName} dictionary is {data}");
//
// #if UNITY_EDITOR
//             if (providers.Count == 0)
//             {
//                 OnGameActivated();
//             }
// #endif
//
//             foreach (var analyticProvider in providers)
//             {
//                 analyticProvider.Send(eventName, data, importanceCode);
//             }
//
//         }
//
//
//
//         public static void RawEvent(string id, Dictionary<string, object> data = null, int importanceCode = 0)
//         {
//             Send(id, data, importanceCode);
//         }
//
//
//         public static void Purchase(PurchaseAnalyticsData purchaseAnalyticsData)
//         {
//             foreach (var analyticProvider in providers)
//             {
//                 analyticProvider.SendPurchase(purchaseAnalyticsData);
//             }
//         }
//
//         public static void Subscription(SubscriptionAnalyticsData subscriptionAnalyticsData)
//         {
//             foreach (var analyticProvider in providers)
//             {
//                 analyticProvider.SendSubscription(subscriptionAnalyticsData);
//             }
//         }
//
//         public static void SetUserProperty(string property, object n)
//         {
//             // DLog("SetUserProperty:" + property + " to: " + n);
//             foreach (var analyticProvider in providers)
//             {
//                 analyticProvider.SetUserProperty(property, n);
//             }
//
//         }
//
//
//     }
//
// }
