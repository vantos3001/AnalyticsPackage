// using System;
// using System.Collections.Generic;
// using Common.Analytics;
// using Common.Analytics.Providers;
// using UnityEngine;
//
// namespace AnalyticsPackage.Scripts
// {
//     public class AmplitudeAnalyticsProvider : IAnalyticProvider
//     {
//         private const string AmplitudeId = "test";
//         
//         private bool isActive = false;
//
//         public AmplitudeAnalyticsProvider()
//         {
//             if (Application.isEditor)
//             {
//                 return;
//             }
//
//             isActive = true;
//
//             var amplitude = Amplitude.Instance;
//             amplitude.logging = false;
//             amplitude.init(AmplitudeId);
//
//             amplitude.setOnceUserProperty("InstallDate", GetInstallDateInFormat());
//             amplitude.addUserProperty("LaunchCount",1);        
//             amplitude.trackSessionEvents(true);
//
//             Debug.Log("Analytics Amplitude init done");
//
//         }
//
//         private int GetInstallDateInFormat()
//         {
//             var dateDate = DateTime.Now.Date;
//             int result = dateDate.Year * 10000 + dateDate.Month * 100 + dateDate.Day;
//             return result;
//         }
//
//
//         public void Send(string eventName, Dictionary<string, object> data, int importanceCode)
//         {
//             if (!isActive) return;
//
//             /*if (importanceCode > 0)
//             {
//                 Debug.Log("Importance code 1 -  send anyway:" + eventName);
//                 Amplitude.Instance.logEvent(eventName, data);
//                 return;
//             }
//             if (ABTestsManager.IsBTest(ABTestsManager.GetABAmplitudeAnalyticsProviderTest())) return;
//             if (ABHelper.IsCountry("US") || ABHelper.IsCountry("RU"))
//             {
//                 Amplitude.Instance.logEvent(eventName, data);
//
//                 // Debug.Log("AnalyticsController: Amplitude send event:" + eventName);
//             }*/
//             Amplitude.Instance.logEvent(eventName, data);
//         }
//
//         
//         public void SendPurchase(PurchaseAnalyticsData purchaseAnalyticsData)
//         {
//             if (!isActive) return;
//
//             // if (!ABHelper.IsCountry("US")) return;
//             // if (ABHelper.AnalyticsCohortUS > 1) return;
//             
//             
//             //TODO: need to use LocalCurrencyValueForAnalytics or LocalizedPriceString??
//             
// #if UNITY_ANDROID && !UNITY_EDITOR 
//             Amplitude.Instance.logRevenue(purchaseAnalyticsData.ProductName,1, purchaseAnalyticsData.LocalCurrencyValueForAnalytics, purchaseAnalyticsData.PurchaseData, purchaseAnalyticsData.Signature);
// #endif
//
// #if UNITY_IOS && !UNITY_EDITOR 
//             Amplitude.Instance.logRevenue(purchaseAnalyticsData.ProductName,1, purchaseAnalyticsData.LocalCurrencyValueForAnalytics, purchaseAnalyticsData.TransactionId, null);
// #endif
//         }
//
//         public void SendSubscription(SubscriptionAnalyticsData subscriptionAnalyticsData)
//         {
//             if (!isActive) return;
//         }
//
//         public void SetUserProperty(string name, object property)
//         {
//             if (!isActive) return;
//
//             // Debug.Log("AmplitudeSetUserProperty");
//            
//             if (property is float f)
//             {
//                 // Debug.Log("AmplitudeSetUserProperty (float)");
//                 Amplitude.Instance.setUserProperty(name, f);
//             }
//             else if (property is string s)
//             {
//                 // Debug.Log("AmplitudeSetUserProperty (string)");
//                 Amplitude.Instance.setUserProperty(name, s);
//             }
//             else if (property is int i)
//             {
//                 // Debug.Log("AmplitudeSetUserProperty (int)");
//                 Amplitude.Instance.setUserProperty(name, i);
//             }
//             else if (property is long l)
//             {
//                 // Debug.Log("AmplitudeSetUserProperty (long)");
//                 Amplitude.Instance.setUserProperty(name, l);
//             }
//             else if (property is bool b)
//             {
//                 // Debug.Log("AmplitudeSetUserProperty (bool)");
//                 Amplitude.Instance.setUserProperty(name, b);
//             }
//
//             
//         }
//
//         public void OnApplicationPause(bool pauseStatus)
//         {
//           
//         }
//     }
// }