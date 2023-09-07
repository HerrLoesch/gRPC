using MyHomey.Domain.Common;
namespace MyHomey.Domain.Inventory;

public interface IInventory
{
    void AddDevice(IDevice device);
    IDevice GetDevice(int deviceId);
    IEnumerable<IDevice> GetDevices();
    void UpdateDevice(IDevice device);
    void DeleteDevice(int deviceId);
}

public interface IDevice
{
}

public class DeviceCreatedEvent : Event<IDevice> 
{
    public DeviceCreatedEvent(IDevice device)
    {
        this.Payload = device;        
    }

    public DeviceCreatedEvent(IDevice device, DateTime creationDate)
    {
        this.Payload = device;        
    }
}