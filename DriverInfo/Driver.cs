using DriverInfo.ConsoleApp.Extensions;

namespace DriverInfo.ConsoleApp
{
    public class Driver
    {
        /// <summary>
        /// Nome do Dispositivo.
        /// </summary>
        /// <remarks>
        /// Representa o nome identificador do dispositivo. Este nome é frequentemente
        /// o mesmo que aparece no Gerenciador de Dispositivos do Windows.
        /// </remarks>
        public string? DeviceName { get; private set; }

        /// <summary>
        /// Classe do Dispositivo.
        /// </summary>
        /// <remarks>
        /// Define a categoria geral do dispositivo, como 'Disco', 'Imagem', 'Rede',
        /// 'Som', etc., ajudando a classificar o tipo de hardware.
        /// </remarks>
        public string? DeviceClass { get; private set; }

        /// <summary>
        /// Fabricante do Dispositivo.
        /// </summary>
        /// <remarks>
        /// O nome do fabricante do dispositivo. Esta informação é importante para 
        /// identificar exatamente de quem é o hardware, especialmente para buscar
        /// drivers ou suporte técnico.
        /// </remarks>
        public string? Manufacturer { get; private set; }

        /// <summary>
        /// Versão do Driver.
        /// </summary>
        /// <remarks>
        /// A versão do driver instalado para o dispositivo. É útil para verificar
        /// se o driver está atualizado ou para fins de solução de problemas.
        /// </remarks>
        public string? DriverVersion { get; private set; }

        /// <summary>
        /// Data de Lançamento do Driver.
        /// </summary>
        /// <remarks>
        /// A data em que o driver foi lançado pelo fabricante. Esta data pode ser usada
        /// para determinar a novidade do driver e se há atualizações disponíveis.
        /// </remarks>
        public DateTime? DriverDate { get; private set; }

        /// <summary>
        /// Data de Instalação do Driver.
        /// </summary>
        /// <remarks>
        /// Data em que o driver foi instalado no sistema. Pode diferir da data de lançamento
        /// e é útil para o rastreamento da manutenção do sistema e diagnóstico de problemas.
        /// </remarks>
        public DateTime? InstallDate { get; private set; }

        public override string ToString()
        {
            int padWidth = 15;

            string driverInfo = "Device Name".PadRight(padWidth) + ": " + DeviceName.OrDashIfEmpty() + "\n" +
                                "Device Class".PadRight(padWidth) + ": " + DeviceClass.OrDashIfEmpty() + "\n" +
                                "Manufacturer".PadRight(padWidth) + ": " + Manufacturer.OrDashIfEmpty() + "\n" +
                                "Driver Version".PadRight(padWidth) + ": " + DriverVersion.OrDashIfEmpty() + "\n" +
                                "Driver Date".PadRight(padWidth) + ": " + (DriverDate?.ToString("yyyy-MM-dd") ?? "-") + "\n" +
                                "Install Date".PadRight(padWidth) + ": " + (InstallDate?.ToString("yyyy-MM-dd") ?? "-") + "\n";

            return driverInfo;
        }

    }
}
