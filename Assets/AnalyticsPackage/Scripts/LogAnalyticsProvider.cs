using System.Collections.Generic;
using System.Text;
using AnalyticsPackage.Scripts;
using UnityEngine;

namespace Common.Analytics.Providers
{
    public class LogAnalyticsProvider : IAnalyticProvider
    {
        public LogAnalyticsProvider()
        {
        }

        public void Send(string eventName, Dictionary<string, object> data, int importanceCode)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"LogAnalytics: analytic event {eventName}");

            foreach (var fieldPair in data)
            {
                stringBuilder.Append("\n");
                stringBuilder.Append($"{fieldPair.Key} : {fieldPair.Value}");
            }
            
            Debug.Log(stringBuilder.ToString());
        }


        public void SendPurchase(PurchaseAnalyticsData purchaseAnalyticsData)
        {
            Debug.Log(
                $"LogAnalytics: purchase analytic event {purchaseAnalyticsData.ProductName} {purchaseAnalyticsData.IsoCurrencyCode} {purchaseAnalyticsData.GetCurrencyValueString()}");
        }

        public void SendSubscription(SubscriptionAnalyticsData subscriptionAnalyticsData)
        {
            Debug.Log(
                $"LogAnalytics: subscription analytic event {subscriptionAnalyticsData.ProductName} {subscriptionAnalyticsData.IsoCurrencyCode} {subscriptionAnalyticsData.GetCurrencyValueString()}");
        }

        public void SetUserProperty(string name, object property)
        {
            Debug.Log($"LogAnalytics: property set {name} to {property} ");
        }

        public void OnApplicationPause(bool pauseStatus)
        {
        }
    }
}