/*using lesson2;

namespace Seminar02;

public class Device : IControllable
{
    public bool IsOn { get; private set; } = false;

    public void On()
    {
        IsOn = true;
    }

    public void Off()
    {
        IsOn = false;
    }
}


public interface IControllable
{
    bool IsOn { get; }
    void On();
    void Off();
}

public class Devices
{
    public List<IControllable> DevicesList { get; init; }
    public Devices()
    {
        DevicesList =
        [
            new Device(),
            new Device(),
            new Device(),
            new Device(),
            new Device(),
            new Device(),
            new Device(),
            new Device(),
        ];
    }

    public void TurnOnOff(Bits bits)
    {
        for (byte i = 0; i < 8; i++)
        {
            if (DevicesList[i].IsOn && !bits[i])
                DevicesList[i].Off();
            else if (!DevicesList[i].IsOn && bits[i])
                DevicesList[i].On();
        }
    }

    public override string ToString()
    {
        return string.Join("", DevicesList.Select(s => s.IsOn ? "1" : "0"));
    }
}*/