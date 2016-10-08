using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text.RegularExpressions;
using SmsSender.Application.GSMServices;

namespace SmsSender.Application.PortManagement
{
    public class AutoDetectGsmPort
    {
        private IList<string> _availablePorts;
        private int _baudRate;
        private int _dataBits;
        private int _readTimeout;
        private int _writeTimeout;
        private string _modelType = "K4510";
        private PortManagement _desiredPortManagement;
        public AutoDetectGsmPort()
        {
            SetPortConfiguration();
        }
        private void SetPortConfiguration()
        {
            _baudRate = 9600;
            _dataBits = 8;
            _readTimeout = 300;
            _writeTimeout = 300;
        }
        public PortManagement DesiredPortManagement
        {
            get { return _desiredPortManagement; }
        }
        private PortManagement GetDesiredPCUIPort1(PortManagement portManagement)
        {
            var portNameChanged = portManagement.PortName;
            var resultString = Convert.ToInt32(Regex.Match(portNameChanged, @"\d+").Value);
            var newResultString = resultString + 1;
            var newPortNameChanged = portNameChanged.Replace(resultString.ToString(), newResultString.ToString());
            portManagement.ClosePort();
            portManagement.PortName = newPortNameChanged;
            portManagement.OpenPort();
            return portManagement;
        }
        private static PortManagement GetDesiredPcuiPort2(PortManagement portManagement)
        {
            var portNameChanged = portManagement.PortName;
            var resultString = Convert.ToInt32(Regex.Match(portNameChanged, @"\d+").Value);
            var newResultString = resultString - 1;
            var newPortNameChanged = portNameChanged.Replace(resultString.ToString(), newResultString.ToString());
            portManagement.ClosePort();
            portManagement.PortName = newPortNameChanged;
            portManagement.OpenPort();
            return portManagement;
        }
        public bool IsNeededPort()
        {
            _availablePorts = SerialPort.GetPortNames().ToList();
            foreach (var tempPortManagement in _availablePorts.Select(port => new PortManagement()
            {
                PortName = port,
                BaudRate = _baudRate,
                DataBits = _dataBits,
                ReadTimeout = _readTimeout,
                WriteTimeout = _writeTimeout
            }))
            {
                tempPortManagement.OpenPort();
                var modelVerifierService = new ModelVerifierService(_modelType)
                {
                    PortManagement = tempPortManagement
                };
                if (modelVerifierService.IsMyGsmDevice())
                {
                    try
                    {
                        _desiredPortManagement = GetDesiredPCUIPort1(tempPortManagement);
                    }
                    catch (IOException)
                    {
                        _desiredPortManagement = GetDesiredPcuiPort2(tempPortManagement);
                    }
                    return true;
                }
                else
                {
                    tempPortManagement.ClosePort();
                }
            }
            return false;
        }
    }
}
