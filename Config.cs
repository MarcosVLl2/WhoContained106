using System.ComponentModel;
using Exiled.API.Interfaces;

namespace WhoContained106
{
    public sealed class Config : IConfig
    {
        [Description("Plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Message duration time in seconds")]
        public ushort MessageDurationInSeconds { get; set; } = 10;

        [Description("Custom message to output when recontainment is successful")]
        public string Message { get; set; } = "{Player} se ha sacrificado como {Role} para eliminar a SCP-106";
    }
}