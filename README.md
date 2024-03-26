# Driver Info

O Driver Information Service é uma aplicação de console em C# destinada a listar informações detalhadas sobre os drivers de dispositivos no sistema operacional Windows. Utilizando a Windows Management Instrumentation (WMI), esta aplicação fornece uma visão abrangente dos drivers assinados Plug and Play (PnP) instalados, apresentando detalhes como nome do dispositivo, classe do dispositivo, fabricante, versão do driver e data da última atualização do driver.

## Funcionalidades

- Listagem de todos os drivers de dispositivos PnP assinados no sistema.
- Apresentação de informações detalhadas e relevantes sobre cada driver.
- Saída formatada de maneira clara e legível, facilitando a análise das informações.

## Tecnologias Utilizadas

- **Linguagem de Programação**: C#
- **Plataforma**: .NET (Compatível com as versões mais recentes do .NET Core e .NET Framework)
- **APIs e Bibliotecas**:
  - Windows Management Instrumentation (WMI) para acessar informações de drivers.

## Como Usar

Para executar o Driver Information Service, siga estes passos:

1. **Pré-requisitos**: Certifique-se de ter o .NET SDK instalado em seu sistema. A aplicação é compatível com Windows devido à dependência do WMI.

2. **Compilação do Projeto**:
   - Abra o terminal ou prompt de comando.
   - Navegue até a pasta do projeto.
   - Execute o comando `dotnet build` para compilar o projeto.

3. **Execução**:
   - Após a compilação, navegue até a pasta `bin/Debug/netX.Y` (onde `X.Y` é a versão do .NET utilizada).
   - Execute o arquivo `DriverInfo.ConsoleApp.exe` para iniciar a aplicação.

## Exemplo de Saída

A saída do programa será similar ao seguinte formato, listando informações detalhadas sobre cada driver encontrado no sistema:

```
Device Name    : Intel(R) Ethernet Connection
Device Class   : Net
Manufacturer   : Intel Corporation
Driver Version : 12.15.23.7
Driver Date    : 2021-03-29

Device Name    : NVIDIA GeForce GTX 4060 Ti
Device Class   : Display
Manufacturer   : NVIDIA
Driver Version : 27.21.14.5671
Driver Date    : 2024-02-01
```

**Nota**: A saída real variará dependendo dos dispositivos e drivers instalados no seu sistema.
