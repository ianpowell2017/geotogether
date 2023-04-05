using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Geotogether.DTOs.Device
{
    public class GetAllDeviceData
    {
        [JsonPropertyName("ttl")] public int Ttl { get; set; }
        [JsonPropertyName("latestUtc")] public int LatestUtc { get; set; }
        [JsonPropertyName("id")] public string Id { get; set; }
        [JsonPropertyName("totalConsumptionList")] public Totalconsumptionlist[] TotalConsumptionList { get; set; }
        [JsonPropertyName("totalConsumptionTimestamp")] public int TotalConsumptionTimestamp { get; set; }
        [JsonPropertyName("supplyStatusList")] public Supplystatuslist[] SupplyStatusList { get; set; }
        [JsonPropertyName("supplyStatusTimestamp")] public int SupplyStatusTimestamp { get; set; }
        [JsonPropertyName("billToDateList")] public Billtodatelist[] BillToDateList { get; set; }
        [JsonPropertyName("billToDateTimestamp")] public int BillToDateTimestamp { get; set; }
        [JsonPropertyName("activeTariffList")] public Activetarifflist[] ActiveTariffList { get; set; }
        [JsonPropertyName("activeTariffTimestamp")] public int ActiveTariffTimestamp { get; set; }
        [JsonPropertyName("currentCostsElec")] public CurrentCost[] CurrentCostsElec { get; set; }
        [JsonPropertyName("currentCostsElecTimestamp")] public int CurrentCostsElecTimestamp { get; set; }
        [JsonPropertyName("currentCostsGas")] public CurrentCost[] CurrentCostsGas { get; set; }
        [JsonPropertyName("currentCostsGasTimestamp")] public int CurrentCostsGasTimestamp { get; set; }
        [JsonPropertyName("prePayDebtList")] public object PrePayDebtList { get; set; }
        [JsonPropertyName("prePayDebtTimestamp")] public int PrePayDebtTimestamp { get; set; }
        [JsonPropertyName("billingMode")] public Billingmode[] BillingMode { get; set; }
        [JsonPropertyName("billingModeTimestamp")] public int BillingModeTimestamp { get; set; }
        [JsonPropertyName("budgetRagStatusDetails")] public Budgetragstatusdetail[] BudgetRagStatusDetails { get; set; }
        [JsonPropertyName("budgetRagStatusDetailsTimestamp")] public int BudgetRagStatusDetailsTimestamp { get; set; }
        [JsonPropertyName("budgetSettingDetails")] public Budgetsettingdetail[] BudgetSettingDetails { get; set; }
        [JsonPropertyName("budgetSettingDetailsTimestamp")] public int BudgetSettingDetailsTimestamp { get; set; }
        [JsonPropertyName("setPoints")] public Setpoints SetPoints { get; set; }
        [JsonPropertyName("seasonalAdjustments")] public Seasonaladjustment[] SeasonalAdjustments { get; set; }
    }

    public class Setpoints
    {
        [JsonPropertyName("daySetPoint")] public SetPoint DaySetPoint { get; set; }
        [JsonPropertyName("nightSetPoint")] public SetPoint NightSetPoint { get; set; }
    }

    public class SetPoint
    {
        [JsonPropertyName("temperatureSetPoint")] public int TemperatureSetPoint { get; set; }
        [JsonPropertyName("timeOfChange")] public int TimeOfChange { get; set; }
    }

    public class Totalconsumptionlist
    {
        [JsonPropertyName("commodityType")] public string CommodityType { get; set; }
        [JsonPropertyName("readingTime")] public int ReadingTime { get; set; }
        [JsonPropertyName("totalConsumption")] public float TotalConsumption { get; set; }
        [JsonPropertyName("valueAvailable")] public bool ValueAvailable { get; set; }
    }

    public class Supplystatuslist
    {
        [JsonPropertyName("commodityType")] public string CommodityType { get; set; }
        [JsonPropertyName("supplyStatus")] public string SupplyStatus { get; set; }
    }

    public class Billtodatelist
    {
        [JsonPropertyName("commodityType")] public string CommodityType { get; set; }
        [JsonPropertyName("billToDate")] public float BillToDate { get; set; }
        [JsonPropertyName("validUTC")] public int ValidUTC { get; set; }
        [JsonPropertyName("startUTC")] public int StartUTC { get; set; }
        [JsonPropertyName("duration")] public int Duration { get; set; }
        [JsonPropertyName("valueAvailable")] public bool ValueAvailable { get; set; }
    }

    public class Activetarifflist
    {
        public string commodityType { get; set; }
        public bool valueAvailable { get; set; }
        public int nextTariffStartTime { get; set; }
        public float activeTariffPrice { get; set; }
        public float nextTariffPrice { get; set; }
        public bool nextPriceAvailable { get; set; }
    }

    public class CurrentCost
    {
        public string commodityType { get; set; }
        public string duration { get; set; }
        public int period { get; set; }
        public float costAmount { get; set; }
        public float energyAmount { get; set; }
    }

    public class Billingmode
    {
        public string billingMode { get; set; }
        public string commodityType { get; set; }
        public bool valueAvailable { get; set; }
    }

    public class Budgetragstatusdetail
    {
        public string currDay { get; set; }
        public string yesterDay { get; set; }
        public string currWeek { get; set; }
        public string lastWeek { get; set; }
        public string currMth { get; set; }
        public string lastMth { get; set; }
        public string thisYear { get; set; }
        public bool valueAvailable { get; set; }
        public string commodityType { get; set; }
    }

    public class Budgetsettingdetail
    {
        public bool valueAvailable { get; set; }
        public float energyAmount { get; set; }
        public float costAmount { get; set; }
        public int budgetToC { get; set; }
        public string commodityType { get; set; }
    }

    public class Seasonaladjustment
    {
        public bool valueAvailable { get; set; }
        public string commodityType { get; set; }
        public bool adjustment { get; set; }
        public int timeOfChange { get; set; }
    }

}
