﻿using HPiLO4HealthReader.XmlGenerated;

namespace HPiLO4HealthReader.DTO
{
    public readonly record struct HostData
    {
        public readonly string? Family { get; }
        public readonly DateOnly? ProductionDate { get; }
        public readonly string? ProductName { get; }
        public readonly string? SerialNumber { get; }
        public readonly List<Processor> Processors { get; }
        public readonly List<MemorySlot> MemorySlots { get; }
        public readonly List<NetworkCard> NetworkCards { get; }

        public HostData(ServerHostData hostData)
        {
            Family = hostData.GetData(0, "Family");
            ProductName = hostData.GetData(1, "Product Name");
            SerialNumber = hostData.GetData(1, "Serial Number");

            var productionDateStr = hostData.GetData(0, "Date");
            ProductionDate = productionDateStr != null ? DateOnly.Parse(productionDateStr) : null;

            var processors = hostData.GetData(4, "Serial Number");

            Processors = hostData
                .GetDataArray(4, "Label", "Speed", "Execution Technology", "Memory Technology")
                .Select(e=>new Processor
                {
                    Name = e["Label"],
                    Speed = e["Speed"],
                    ExecutionTechnology = e["Execution Technology"],
                    MemoryTechnology = e["Memory Technology"]
                }).ToList();

            MemorySlots = hostData
                .GetDataArray(17, "Label", "Size", "Speed")
                .Select(e => new MemorySlot
                {
                    Name = e["Label"],
                    Size = e["Size"],
                    Speed = e["Speed"]
                }).ToList();

            var networkInterfacesFromHost = hostData.GetArrayData(209, "Port", "MAC");
            var networkInterfacesCount = networkInterfacesFromHost[networkInterfacesFromHost.Keys.First()].Count;
            NetworkCards = new List<NetworkCard>(networkInterfacesCount);
            for (int i = 0; i < networkInterfacesCount; i++)
            {
                NetworkCards.Add(new NetworkCard
                {
                    PortName = networkInterfacesFromHost["Port"][i],
                    Mac = networkInterfacesFromHost["MAC"][i]
                });
            }
        }
    }

    public static class ServerHostDataExtensions
    {
        public static string? GetData(this ServerHostData hostData, byte smBIOSRecordType, string smBIOSRecordTypeFieldName) =>
            hostData.GET_HOST_DATA
                .FirstOrDefault(e => e.TYPE == smBIOSRecordType)
                ?.FIELD
                .FirstOrDefault(e => e.NAME == smBIOSRecordTypeFieldName)
                ?.VALUE.Trim();

        public static Dictionary<string, List<string>> GetArrayData(this ServerHostData hostData, byte smBIOSRecordType, params string[] smBIOSRecordTypeFieldNames)
        {
            var retVal = smBIOSRecordTypeFieldNames.ToDictionary(e => e, e => new List<string>());

            var record = hostData.GET_HOST_DATA.FirstOrDefault(e => e.TYPE == smBIOSRecordType);
            if (record == null)
                return retVal;

            foreach (var fieldName in smBIOSRecordTypeFieldNames)
                retVal[fieldName] = record
                    .FIELD
                    .Where(e => e.NAME == fieldName)
                    .Select(e => e.VALUE.Trim()).ToList();

            return retVal;
        }

        public static List<Dictionary<string, string?>> GetDataArray(this ServerHostData hostData, byte smBIOSRecordType, params string[] smBIOSRecordTypeFieldNames)
        {
            var records = hostData.GET_HOST_DATA.Where(e => e.TYPE == smBIOSRecordType);

            var retVal = new List<Dictionary<string, string?>>();
            foreach (var record in records)
            {
                var dict = new Dictionary<string, string?>();

                foreach (var fieldName in smBIOSRecordTypeFieldNames)
                    dict.Add(fieldName, record.FIELD.FirstOrDefault(e => e.NAME == fieldName)?.VALUE.Trim());

                retVal.Add(dict);
            }

            return retVal;
        }
    }
}
