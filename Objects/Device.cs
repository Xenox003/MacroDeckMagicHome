using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck.Variables;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Xenox003.MagicHome.Manager;
using Xenox003.MagicHome.Views;

namespace Xenox003.MagicHome.Objects
{
    public enum DeviceType { LIGHT,UNDEFINED }
    public class Device
    {
        public IPAddress IP { get; private set; }
        public String Name { get; private set; } = "";
        public Boolean UseUpdateCycle { get; set; } = false;
        public String onStateChangeVarName { get; private set; }
        public String onColorChangeVarName { get; private set; }
        public DeviceType type { get; protected set; } = DeviceType.UNDEFINED;
        public bool Connected { get; protected set; } = false;

        public Device(IPAddress IPAddress)
        {
            this.IP = IPAddress;
        }

        public void setName(String name)
        {
            this.Name = name;
            DeviceManager.deviceUpdateSignal();
        }

        public void setOnStateChangeVarName(String value)
        {
            this.onStateChangeVarName = value;
        }
        public void setOnColorChangeVarName(String value)
        {
            this.onColorChangeVarName = value;
        }

        public JObject toJObject()
        {
            JObject obj = new JObject();

            obj["IP"] = this.IP.ToString();
            obj["name"] = this.Name;
            obj["useUpdateCycle"] = this.UseUpdateCycle;
            obj["onStateChangeVar"] = this.onStateChangeVarName;
            obj["onColorChangeVar"] = this.onColorChangeVarName;

            return obj;
        }
        public static Device fromJObject(JObject obj)
        {
            Device device = new Device(IPAddress.Parse(obj["IP"].ToString()));

            device.Name = obj["name"].ToString();
            device.UseUpdateCycle = obj["useUpdateCycle"].ToObject<bool>();
            device.onStateChangeVarName = obj["onStateChangeVar"].ToString();
            device.onColorChangeVarName = obj["onColorChangeVar"].ToString();

            return device;
        }

        public override string ToString()
        {
            return this.IP.ToString() + " | " + this.Name;
        }
    }
}
